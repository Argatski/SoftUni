using _01.ChainOfResponsibility;

internal class Program
{
    private static void Main(string[] args)
    {
        Approver  teamLead =  new TeamLead();
        Approver cto =  new CTO();

        teamLead.SetNext(cto);

        Console.WriteLine(teamLead.HandleRequest(3));
        Console.WriteLine(teamLead.HandleRequest(50));
        Console.WriteLine(teamLead.HandleRequest(5000));
    }
}