namespace IDF_Project;

public class IDF : MilitaryOrganization
{
    protected override int yearOfConstruction { get ; set; }
    protected  override string chiefOfStaff { get ; set; }

    private List<StrikeOptions> strikeOptionList; 

    public IDF(int yearOfConstruction, string chiefOfStaff)
    {
        this.yearOfConstruction = yearOfConstruction;
        this.chiefOfStaff = chiefOfStaff;
        this.strikeOptionList = new List<StrikeOptions>(); 
    }

    public void AddStrikeOption(StrikeOptions newTool)
    {
        this.strikeOptionList.Add(newTool);

    }

    public void RemoveStrikeOption(StrikeOptions currentTool)
    {
        this.strikeOptionList.Remove(currentTool);
    }
    public List<StrikeOptions> GetToolsList()
    {
        return this.strikeOptionList;
    }

}
