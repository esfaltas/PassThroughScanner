using ConsoleApp1;
using ConsoleApp1.Services;

public class Program
{
    public static void Main(string[] args)
    {
        var visitorsRep = new VisitorsRepository();
        var cs = new CheckService();
        visitorsRep.VisitorsList();
        cs.Check();
    }
}