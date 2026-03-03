using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;
using System.Net;
using System.Runtime.CompilerServices;
using static lab5.BookstoreContext;
using static lab5.Form1;

namespace lab5
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
            public string Name { get; set; }
            public virtual ICollection<Book> Books { get; set; }
        }

        public class Book
        {
            public int BookID { get; set; }
            public string Title { get; set; }
            public int AuthorID { get; set; }
            public virtual Author Author { get; set; }
        }

        public void AddAuthorWithBook(string authorName, string bookTitle)
        {
            using (var context = new BookstoreContext())
            {
                var author = new Author { Name = authorName };
                var book = new Book { Title = bookTitle, Author = author };

                context.Authors.Add(author);
                context.Books.Add(book);
                context.SaveChanges();
            }

        }

        public List<string> GetBooksWithAuthors()
        {
            using (var context = new BookstoreContext())
            {
                var booksWithAuthors = context.Books
                    .Include(book => book.Author)
                    .Select(b => $"{b.Title} by {b.Author.Name}")
                    .ToList();
                return booksWithAuthors;
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            AddAuthorWithBook(txtAuthorName.Text, txtBookTitle.Text);
        }

        private void btnShowBooks_Click(object sender, EventArgs e)
        {
            var books = GetBooksWithAuthors();
            listBoxBooks.Items.Clear();
            foreach (var b in books)
            {
                listBoxBooks.AddItem(b);
            }
        }

        public void UpdateBookAndAuthor(int bookId, string newTitle, string newAuthorName)
        {
            using (var context = new BookstoreContext())
            {
                var book = context.Books.Include(b => b.Author).FirstOrDefault(b => b.BookID == bookId);
                if (book != null)
                {
                    book.Title = newTitle;
                    book.Author.Name = newAuthorName;
                    context.SaveChanges();
                }
            }
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            int bookId = int.Parse(txtBookID.Text);
            UpdateBookAndAuthor(bookId, txtBookTitle.Text, txtAuthorName.Text);
            MessageBox.Show("Book and Author updated successfully.");
        }

        public void DeleteBook(int bookId)
        {
            using (var context = new BookstoreContext())
            {
                var book = context.Books.FirstOrDefault(b => b.BookID == bookId);
                if (book != null)
                {
                    context.Books.Remove(book);
                    context.SaveChanges();
                    MessageBox.Show("Book deleted successfully.");
                }
                else
                {
                    MessageBox.Show("Book ID not found.");
                }
            }
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBookID.Text, out int bookId))
            {
                DeleteBook(bookId);
                btnShowBooks_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Please enter a valid Book ID.");
            }
        }

        public List<string> SearchBooksByAuthor(string authorName)
        {
            using (var context = new BookstoreContext())
            {
                return context.Books
                    .Include(b => b.Author)
                    .Where(b => b.Author.Name.Contains(authorName))
                    .Select(b => $"{b.Title} by {b.Author.Name}")
                    .ToList();
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();
            if (!string.IsNullOrEmpty(searchTerm))
            {
                var results = SearchBooksByAuthor(searchTerm);
                listBoxBooks.Items.Clear();

                if (results.Any())
                {
                    foreach (var res in results)
                    {
                        listBoxBooks.AddItem(res);
                    }
                }
                else
                {
                    MessageBox.Show("No books found for that author.");
                }
            }
            else
            {
                btnShowBooks_Click(sender, e);
            }
        }
    }
}
