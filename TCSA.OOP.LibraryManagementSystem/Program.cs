using Spectre.Console;

var menuChoices = new string[3] { "View Books", "Add Book", "Delete Book" };
var books = new List<string>()
{
    "Ostatnie życzenie", "Miecz przeznaczenia", "Krew elfów", "Chrzest ognia", "Czas pogardy", "Pani jeziora", "Wieża jaskółki","Sezon burz", "Rozdroże kruków"
};

while (true)
{
    Console.Clear();
    var choice = AnsiConsole.Prompt(
    new SelectionPrompt<MenuOption>()
        .Title("What do you want to do next?")
        .AddChoices(Enum.GetValues<MenuOption>()));

    switch (choice)
    {
        case MenuOption.ViewBooks:
            ViewBooks();
            break;
        case MenuOption.AddBook:
            AddBook();
            break;
        case MenuOption.DeleteBook:
            DeleteBook();
            break;
    }

}

void ViewBooks()
{
    AnsiConsole.MarkupLine("[yellow]List of Books:[/]");
            foreach (var book in books)
            {
                AnsiConsole.MarkupLine($"- [cyan]{book}[/]");
            }
            AnsiConsole.MarkupLine("Press any key to continue");
            Console.ReadKey();
}

void AddBook()
{
    var title = AnsiConsole.Ask<string>("Enter the [green]title[/] of the book to add:");
    if (books.Contains(title))
    {
        AnsiConsole.MarkupLine("[red]This book already exists.[/]");
    }
    else
    {
        books.Add(title);
        AnsiConsole.MarkupLine("[green]Book added successfully.[/]");
    }
    AnsiConsole.MarkupLine("Press any key to continue.");
    Console.ReadKey();
}

void DeleteBook()
{
    if (books.Count == 0)
    {
        AnsiConsole.MarkupLine("[red]No books available to delete.[/]");
        Console.ReadKey();
        return;
    }
    var bookToDelete = AnsiConsole.Prompt(
        new SelectionPrompt<string>()
        .Title("Select a [red]book[/] to delete:")
        .AddChoices(books)
    );

    if (books.Remove(bookToDelete))
    {
        AnsiConsole.MarkupLine("[red]Book deleted successfully![/]");
    }
    else
    {
        AnsiConsole.MarkupLine("[red]Book not found.[/]");
    }
    AnsiConsole.MarkupLine("Press any key to continue.");
    Console.ReadKey();
    
}

enum MenuOption
{
    ViewBooks,
    AddBook,
    DeleteBook
}

