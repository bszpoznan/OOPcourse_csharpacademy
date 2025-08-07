using Spectre.Console;
using TCSA.OOP.LibraryManagementSystem.Models;

namespace TCSA.OOP.LibraryManagementSystem;

internal class Magazine : LibraryItem
{
    internal string Publisher { get; set; }
    internal DateTime PublishDate { get; private set; }
    internal int IssueNumber { get; set; }

    internal Magazine(int id, string name, string publisher, DateTime publishDate, string location, int issueNumber)
    : base(id, name, location)
    {
        Publisher = publisher;
        IssueNumber = issueNumber;
        PublishDate = publishDate;
    }

    public override void DisplayDetails()
    {
        var panel = new Panel(new Markup($"[bold]Magazine:[/] [cyan]{Name}[/] by [cyan]{Publisher}[/]") +
                                         $"\n[bold]Issue Number:[/] {IssueNumber}" +
                                         $"\n[bold]Publication Date:[/] {PublishDate:yyyy-MM-dd}" +
                                         $"\n[bold]Location:[/] [blue]{Location}[/]")


        {
            Border = BoxBorder.Rounded
        };
        AnsiConsole.Write(panel);

    }
}
