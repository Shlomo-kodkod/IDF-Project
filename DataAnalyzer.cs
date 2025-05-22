namespace IDF_Project;

public class DataAnalyzer
{
    public void GetAllStrikeOptions(IDF idf)
    {
        Console.WriteLine(string.Join("\n",idf.GetToolsList()));
    }

    public Terrorist GetMostDangerousTerrorist(List<Terrorist> list)
    {
        Terrorist mostDangereous = null;
        int score = 0;
        foreach (Terrorist terrorist in list)
        {
            int tscore = GetTerroristScore(terrorist);
            if (tscore>score)
            {
                mostDangereous = terrorist;
                score = tscore;
            }
        }
        return mostDangereous;
    }

    private int GetTerroristScore(Terrorist terrorist)
    {
        int score = terrorist.GetRank() * terrorist.GetWeapons().Length;
        return score;
    }
    
}