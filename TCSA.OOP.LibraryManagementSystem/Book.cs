namespace TCSA.OOP.LibraryManagementSystem
{
    public class Book
    {
        public string Name { get; private set; } = "Unknown";
        public int Pages { get; private set; } = 0;

        internal Book(string name, int pages)
        {
            Name = name;
            Pages = pages;
        }
    }
}