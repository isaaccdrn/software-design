using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace lab6
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Author
        {
            public int AuthorID { get; set; }
            public required string Name { get; set; }
            public virtual ICollection<Book> ?Books { get; set; }
        }

        public class Book
        {
            public int BookID { get; set; }
            public required string Title { get; set; }
            public int AuthorID { get; set; }
            public virtual required Author Author { get; set; }
        }

        public async Task<List<string>> GetBooksAsync()
        {
            using (var context = new BookstoreContext())
            {
                var books = await context.Books.Include(b => b.Author)
                                               .Select(b => $"{b.Title} by {b.Author.Name}")
                                               .ToListAsync();
                return books;
            }
        }

        private async void btnFetchBooks_Click(object sender, EventArgs e)
        {
            progressBar.Value = 0;

            var progress = new Progress<int>(percent =>
            {
                progressBar.Value = percent;
            });

            var books = await GetBooksWithProgressAsync(progress);

            listBoxBooks.Items.Clear();
            foreach (var b in books)
            {
                listBoxBooks.AddItem(b);
            }
        }

        public async Task SaveBookAsync(string bookTitle, string authorName)
        {
            using var context = new BookstoreContext();
            var author = new Author { Name = authorName };
            var book = new Book { Title = bookTitle, Author = author };

            context.Authors.Add(author);
            context.Books.Add(book);

            await context.SaveChangesAsync();
        }

        private async void btnAddBook_Click(object sender, EventArgs e)
        {
            var authorName = txtAuthorName.Text;
            var bookTitle = txtBookTitle.Text;

            await SaveBookAsync(bookTitle, authorName);
            MessageBox.Show("Book and Author saved successfully!");
        }

        public async Task UpdateBookAsync(int bookId, string newTitle, string newAuthor)
        {
            using var context = new BookstoreContext();
            var book = await context.Books.Include(b => b.Author)
                                         .FirstOrDefaultAsync(b => b.BookID == bookId);
            if (book != null)
            {
                book.Title = newTitle;
                book.Author.Name = newAuthor;
                await context.SaveChangesAsync();
            }
            else
            {
                throw new Exception("Book not found!");
            }
        }

        public async Task DeleteBookAsync(int bookId)
        {
            using var context = new BookstoreContext();
            var book = await context.Books.FindAsync(bookId);
            if (book != null)
            {
                context.Books.Remove(book);
                await context.SaveChangesAsync();
            }
        }

        public async Task<List<string>> GetBooksWithProgressAsync(IProgress<int> progress)
        {
            using var context = new BookstoreContext();
            var rawBooks = await context.Books.Include(b => b.Author).ToListAsync();
            var displayList = new List<string>();

            for (int i = 0; i < rawBooks.Count; i++)
            {
                await Task.Delay(100);

                var b = rawBooks[i];
                displayList.Add($"{b.Title} by {b.Author.Name}");

                int percentComplete = (i + 1) * 100 / rawBooks.Count;
                progress.Report(percentComplete);
            }
            return displayList;
        }

        public async Task<List<string>> SearchBooksAsync(string searchTerm)
        {
            using var context = new BookstoreContext();
            return await context.Books
                .Include(b => b.Author)
                .Where(b => b.Title.Contains(searchTerm))
                .Select(b => $"{b.Title} by {b.Author.Name}")
                .ToListAsync();
        }

        private async void btnUpdateBook_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtBookId.Text);
                await UpdateBookAsync(id, txtBookTitle.Text, txtAuthorName.Text);
                MessageBox.Show("Book updated successfully!");
                btnFetchBooks_Click(sender, e);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private async void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBookId.Text, out int id))
            {
                await DeleteBookAsync(id);
                MessageBox.Show("Book deleted.");
                btnFetchBooks_Click(sender, e);
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var results = await SearchBooksAsync(txtSearch.Text);
            listBoxBooks.Items.Clear();
            foreach (var item in results)
            {
                listBoxBooks.AddItem(item);
            }
        }
        
    }
}
