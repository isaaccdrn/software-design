using static lab4.BookClasses;

namespace lab4
{
    [TestClass]
    public class PolymorphismTests
    {
        [TestMethod]
        public void TestPolymorphism_GetInfo_Method()
        {
            Book[] books = [
                new Book{Title = "Generic Book", Author = "John Smith"  },
                new Magazine {Title = "Tech Weekly", Author = "Jane Doe", IssueNumber = 12},
                new Ebook{Title = "Learn C#", Author = "Mark Jones", FileSizeMB = 5}
            ];

            Assert.AreEqual("Generic Book by John Smith", books[0].GetInfo());
            Assert.AreEqual("Tech Weekly - Issue 12", books[1].GetInfo());
            Assert.AreEqual("Learn C# (Ebook, 5MB)", books[2].GetInfo());
        }

        [TestMethod]
        public void TestBookCreation()
        {
            Book book = new() { Title = "C# Programming", Author = "John Smith" };
            Assert.AreEqual("C# Programming", book.Title);
            Assert.AreEqual("John Smith", book.Author);
        }

        [TestMethod]
        public void TestMagazineCreation()
        {
            Magazine magazine = new() { Title = "Tech Weekly", Author = "Jane Doe", IssueNumber = 12 };
            Assert.AreEqual("Tech Weekly", magazine.Title);
            Assert.AreEqual(12, magazine.IssueNumber);
        }


        [TestMethod]
        public void TestBookCreation_EmptyTitle_ShouldThrowException()
        {
            // Assert.ThrowsException returns the exception object, allowing you to check the message too!
            var ex = Assert.Throws<ArgumentException>(() => {
                Book book = new() { Title = "", Author = "Test Author" };
            });

            Assert.AreEqual("Title cannot be empty", ex.Message);
        }

        [TestMethod]
        public void TestMagazineCreation_NegativeIssue_ShouldThrowException()
        {
            Assert.Throws<ArgumentException>(() => {
                Magazine magazine = new() { Title = "Tech Weekly", IssueNumber = -1 };
            });
        }

        [TestMethod]
        public void TestTextbookCreation_EmptySubject_ShouldThrowException()
        {
            Assert.Throws<ArgumentException>(() => {
                Textbook textbook = new() { Title = "Math 101", Subject = " ", Author = "John Doe" };
            });
        }

        [TestMethod]
        public void TestTextbookCreation_ValidSubject_ShouldSucceed()
        {
            // Arrange & Act
            var textbook = new Textbook { Title = "Biology", Subject = "Science", Author = "Dr. Smith" };

            // Assert
            Assert.AreEqual("Science", textbook.Subject);
            Assert.Contains("[Subject: Science]", textbook.GetInfo());
        }
    }
}
