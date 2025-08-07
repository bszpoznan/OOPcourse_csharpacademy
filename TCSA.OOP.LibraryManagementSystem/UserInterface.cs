using Spectre.Console;
using static TCSA.OOP.LibraryManagementSystem.Enums;
using TCSA.OOP.LibraryManagementSystem.Controllers;
using TCSA.OOP.LibraryManagementSystem.Models;
namespace TCSA.OOP.LibraryManagementSystem;

internal class UserInterface
{
    private readonly BookController _booksController = new();
    private readonly MagazineController _magazineController = new();
    private readonly NewspaperController _newspaperController = new();

    internal void MainMenu()
    {
        bool continueLoop = true;
        while (continueLoop)
        {
            Console.Clear();

            var actionchoice = AnsiConsole.Prompt(
                new SelectionPrompt<MenuOption>()
                .Title("What do you want to do next?")
                .AddChoices(Enum.GetValues<MenuOption>()));

            var itemTypeChoice = ItemType.Book;
            if (actionchoice != MenuOption.Exit)
            {
                itemTypeChoice = AnsiConsole.Prompt(
                    new SelectionPrompt<ItemType>()
                    .Title("Select the type of Item: ")
                    .AddChoices(Enum.GetValues<ItemType>()));
            }
            switch (actionchoice)
            {
                case MenuOption.ViewItems:
                    ViewItems(itemTypeChoice);
                    break;
                case MenuOption.AddItem:
                    AddItem(itemTypeChoice);
                    break;
                case MenuOption.DeleteItem:
                    DeleteItem(itemTypeChoice);
                    break;
                case MenuOption.Exit:
                    continueLoop = false;
                    break;
            }

        }
    }

    private void ViewItems(ItemType itemTypeChoice)
    {
        switch (itemTypeChoice)
        {
            case ItemType.Book:
                _booksController.ViewItems();
                break;
            case ItemType.Newspaper:
                _newspaperController.ViewItems();
                break;
            case ItemType.Magazine:
                _magazineController.ViewItems();
                break;
        }
    }

    private void AddItem(ItemType itemTypeChoice)
    {
        switch (itemTypeChoice)
        {
            case ItemType.Book:
                _booksController.AddItem();
                break;
            case ItemType.Newspaper:
                _newspaperController.AddItem();
                break;
            case ItemType.Magazine:
                _magazineController.AddItem();
                break;
        }
    }
    
    private void DeleteItem(ItemType itemTypeChoice)
    {
        switch (itemTypeChoice)
        {
            case ItemType.Book:
                _booksController.DeleteItem();
                break;
            case ItemType.Newspaper:
                _newspaperController.DeleteItem();
                break;
            case ItemType.Magazine:
                _magazineController.DeleteItem();
                break;
        }
    }

    
}
