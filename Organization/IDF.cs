using System.Collections.Generic;

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
        List<StrikeOptions> availableTool = new List<StrikeOptions>();
        foreach (StrikeOptions tool in strikeOptionList)
        {
            if (tool.GetCapacity()>0)
            {
                availableTool.Add(tool);
            }
        }
        return availableTool;
    }
    
    public List<StrikeOptions> GetRelevantToolsList(string targetType)
    {
        List<StrikeOptions> relevantTool = new List<StrikeOptions>();
        List<StrikeOptions> availableTool = GetToolsList();
        foreach (StrikeOptions tool in availableTool)
        {
            if (tool.GettargetType().Contains(targetType))
            {
                relevantTool.Add(tool);
            }
        }
        return relevantTool;
    }

}
