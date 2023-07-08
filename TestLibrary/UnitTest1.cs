using Phil_s_Lending_Library.Classes;
namespace TestLibrary
{
    public class UnitTest1
    {
        [Fact]
        public void TestAddBookToLibrary()
        {
            Library library = new Library();

            library.Add("testTitle", " H", "L", 200);

            Assert.NotEmpty(library);

        }
        [Fact]
        public void TestBorrowExistingTitle()
        {
            Library library = new Library();
            library.Add("testTitle", " H", "L", 200);

            int initialCount = library.Count;

            Book borrowedBook = library.Borrow("testTitle");

            Assert.NotNull(borrowedBook);
            Assert.DoesNotContain(borrowedBook, library);
            Assert.Equal(initialCount - 1, library.Count);
        }
        [Fact]
        public void TestBorrowMissingTitle_ReturnsNull()
        {
            Library library = new Library();
            library.Add("testTitle", " H", "L", 200);

            Book borrowedBook = library.Borrow("missingTitle");

            Assert.Null(borrowedBook);
        }
        [Fact]
        public void TestReturnBook()
        {
            Library library = new Library();
            Book book = new Book("testTitle", " H", "L", 200);

            library.Return(book);

            Assert.Contains(book, library);
            Assert.Single(library);
        }
        [Fact]
        public void TestPackAndUnpackBackpack()
        {
            Backpack<string> backpack = new Backpack<string>();

            backpack.Pack("item1");
            backpack.Pack("item2");

            Assert.Equal("item1", backpack.Unpack(0));
            Assert.Equal("item2", backpack.Unpack(0));
            Assert.Throws<IndexOutOfRangeException>(() => backpack.Unpack(0));


        }
    }
}