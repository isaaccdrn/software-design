using MaterialSkin.Controls;

namespace lab3
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class Book
        {
            required public string Title { get; set; }
            public string? Author { get; set; }
            public virtual string GetInfo() => $"{Title} by {Author}";
        }
        public class Magazine : Book
        {
            public int IssueNumber { get; set; }
            public override string GetInfo() => $"{Title} (Issue #{IssueNumber})";
        }

        public class Ebook : Book
        {
            public float Rating { get; set; }
            public override string GetInfo() => $"{Title} - Rating: {Rating}/5";
        }

        public class Textbook : Book
        {
            required public string Subject { get; set; }
            public override string GetInfo() => $"{Title} by {Author} [Subject: {Subject}] ";
        }


        public class AudioBook : Book
        {
            required public string Duration { get; set; }
            required public string Narrator { get; set; }
            public override string GetInfo() => $"{Title} (Audiobook) - Narrated by {Narrator} [{Duration}]";
        }

        private void ProcessBooks(Book[] inventory)
        {
            booksLBox.Items.Clear();

            foreach (Book b in inventory)
            {
                booksLBox.AddItem(b.GetInfo());
            }
        }


        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            Book[] myInventory =
            {
                new Book { Title = "Fahrenheit 451", Author = "Ray Bradbury" },
                new Magazine { Title = "Tech Weekly", IssueNumber = 45 },
                new Ebook { Title = "Atomic Habits", Rating = 4.8f },
                new Textbook { Title = "University Physics", Author = "Young and Freedman", Subject = "Science" },
                new AudioBook { Title = "Crime and Punishment", Narrator = "Isaac Nathan", Duration = "24h 10m" }
            };

            // Call the polymorphic function
            ProcessBooks(myInventory);
        }

    }
}