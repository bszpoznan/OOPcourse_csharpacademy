using Spectre.Console;
using TCSA.OOP.LibraryManagementSystem.Models;

namespace TCSA.OOP.LibraryManagementSystem;

internal class Newspaper : LibraryItem
{
    internal string Publisher { get; set; }
    internal DateTime PublishDate { get; private set; }


    internal Newspaper(int id, string name, string publisher, DateTime publishDate, string location)
    : base(id, name, location)
    {
        Publisher = publisher;
        PublishDate = publishDate;
    }

    public override void DisplayDetails()
    {
        var panel = new Panel(new Markup($"[bold]Newspaper:[/] [cyan]{Name}[/] by [cyan]{Publisher}[/]") +
                                         $"\n[bold]Publication Date:[/] {PublishDate:yyyy-MM-dd}" +
                                         $"\n[bold]Location:[/] [blue]{Location}[/]")


        {
            Border = BoxBorder.Rounded
        };
        AnsiConsole.Write(panel);

    }
}
