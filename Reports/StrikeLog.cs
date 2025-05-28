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

/// <summary>
    /// Adds a new strike log to the logs list.
    /// </summary>
    /// <param name="terrorist">The terrorist target of the strike.</param>
    /// <param name="typeStrike">The weapon type used.</param>
    /// <param name="operatorName">The name of the operator who executed the strike.</param>
    /// <param name="lastReport">The last intelligence report about the terrorist.</param>
    /// <param name="leftAmmo">The amount of ammunition left in the assault weapon.</param>
    public void AddStrikeLog(Terrorist terrorist, StrikeOptions typeStrike, string operatorName, ReportAman lastReport, int leftAmmo)
    {
        CurentTime = DateTime.Now;
        Terrorist = terrorist;
        TypeStrike = typeStrike;
        OperatorName = operatorName;
        LastReport = lastReport;

        logs.Add(this);
    }
    
/// <summary>
    /// Prints the last strike log.
    /// </summary>
    public void PrintLastLog()
    {
        Console.WriteLine(logs[logs.Count-1]);
    }

/// <summary>
    /// Prints a  strike log entry by its number.
    /// </summary>
    /// <param name="logNum">The log number to print.</param>
    public void PrintLog(int logNum)
    {
        Console.WriteLine(logs[logNum-1]);
    }

/// <summary>
    /// Returns a formatted string representing the strike log details.
    /// </summary>
    public override string ToString()
    {
        return $"Time of Strike : {CurentTime}\n" +
               $"Terrorist : {Terrorist.ToString()}\n" +
               $"Last report : {LastReport.GetLastLocation()} at {LastReport.GetLastTimeStemp()}\n" +
               $"Strike weapon : {TypeStrike.ToString()}\n" +
               $"Operator name : {OperatorName}\n";
    }
}