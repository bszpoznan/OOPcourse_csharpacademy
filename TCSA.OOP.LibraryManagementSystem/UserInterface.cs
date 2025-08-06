using Spectre.Console;
using static TCSA.OOP.LibraryManagementSystem.Enums;

namespace TCSA.OOP.LibraryManagementSystem
{
    public class UserInterface
    {
        internal static void Menu()
        {
            bool continueLoop = true;
            while (continueLoop)
            {
                Console.Clear();
                var choice = AnsiConsole.Prompt(
                new SelectionPrompt<MenuOption>()
                    .Title("What do you want to do next?")
                    .AddChoices(Enum.GetValues<MenuOption>()));

                switch (choice)
                {
                    case MenuOption.ViewBooks:
                        BooksControler.ViewBooks();
                        break;
                    case MenuOption.AddBook:
                        BooksControler.AddBook();
                        break;
                    case MenuOption.DeleteBook:
                        BooksControler.DeleteBook();
                        break;
                    case MenuOption.Exit:
                        continueLoop = false;
                        break;
                }

            }
        }
    }
}