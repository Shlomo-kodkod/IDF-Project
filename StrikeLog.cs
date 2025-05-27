namespace IDF_Project;

public class StrikeLog
{
    private DateTime CurentTime;
    private Terrorist Terrorist;
    private StrikeOptions TypeStrike;
    private string OperatorName;
    private ReportAman LastReport;
    private int LeftAmmo;

    StrikeLog(Terrorist terrorist , StrikeOptions typeStrike,string operatorName, ReportAman lastReport, int leftAmmo)
    {
        CurentTime = DateTime.Now;
        Terrorist = terrorist;
        TypeStrike = typeStrike;
        OperatorName = operatorName;
        LastReport = lastReport;
        LeftAmmo = typeStrike.GetCapacity();
    }

}