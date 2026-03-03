namespace lab4
{
    internal class BookClasses
    {
        public class Book
        {
            private string _title = string.Empty;
            public required string Title
            {
                get => _title;
                set => _title = string.IsNullOrWhiteSpace(value) ? throw new ArgumentException("Title cannot be empty") : value;
            }

            public string? Author { get; set; }
            public virtual string GetInfo() => $"{Title} by {Author}";
        }

        public class Magazine : Book
        {
            private int _issueNumber;
            public int IssueNumber
            {
                get => _issueNumber;
                set => _issueNumber = value < 0 ? throw new ArgumentException("Issue number cannot be negative") : value;
            }
            public override string GetInfo() => $"{Title} - Issue {IssueNumber}";
        }

        public class Ebook : Book
        {
            public int FileSizeMB { get; set; }
            public override string GetInfo() => $"{Title} (Ebook, {FileSizeMB}MB)";
        }

        public class Textbook : Book
        {
            private string _subject = string.Empty;
            public required string Subject
            {
                get => _subject;
                set => _subject = string.IsNullOrWhiteSpace(value) ? throw new ArgumentException("Subject cannot be empty") : value;
            }
            public override string GetInfo() => $"{Title} by {Author} [Subject: {Subject}] ";
        }

        public class AudioBook : Book
        {
            required public string Duration { get; set; }
            required public string Narrator { get; set; }
            public override string GetInfo() => $"{Title} (Audiobook) - Narrated by {Narrator} [{Duration}]";
        }
    }
}