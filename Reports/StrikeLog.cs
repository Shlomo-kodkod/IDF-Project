namespace IDF_Project;

public class StrikeLog
{
    private DateTime CurentTime;
    private Terrorist Terrorist;
    private StrikeOptions TypeStrike;
    private string OperatorName;
    private ReportAman LastReport;
    private List<StrikeLog> logs;

    public StrikeLog()
    {
        logs = new List<StrikeLog>();
    }

    public void AddStrikeLog(Terrorist terrorist, StrikeOptions typeStrike, string operatorName, ReportAman lastReport, int leftAmmo)
    {
        CurentTime = DateTime.Now;
        Terrorist = terrorist;
        TypeStrike = typeStrike;
        OperatorName = operatorName;
        LastReport = lastReport;

        logs.Add(this);
    }
    
    public void PrintLastLog()
    {
        Console.WriteLine(logs[logs.Count-1]);
    }

    public void PrintLog(int logNum)
    {
        Console.WriteLine(logs[logNum-1]);
    }

    public override string ToString()
    {
        return $"Time of Strike : {CurentTime}\n" +
               $"Terrorist : {Terrorist.ToString()}\n" +
               $"Last report : {LastReport.GetLastLocation()} at {LastReport.GetLastTimeStemp()}\n" +
               $"Strike weapon : {TypeStrike.ToString()}\n" +
               $"Operator name : {OperatorName}\n";
    }
}