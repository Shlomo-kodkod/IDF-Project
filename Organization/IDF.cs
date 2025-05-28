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
    
/// <summary>
/// Add a weapon to the IDF list.
/// </summary>
/// <param name="newTool">Weapon to add</param>
    public void AddStrikeOption(StrikeOptions newTool)
    {
        this.strikeOptionList.Add(newTool);

    }

/// <summary>
/// Remove a weapon from the IDF list.
/// </summary>
/// <param name="currentTool">weapon</param>
    public void RemoveStrikeOption(StrikeOptions currentTool)
    {
        this.strikeOptionList.Remove(currentTool);
    }

/// <summary>
/// Returns a list of all weapons that are available for strike.
/// </summary>
/// <returns>a list of all weapons that are available for strike</returns>
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
    
/// <summary>
/// Returns a list of all weapons that are available for strike and match the given target type.
/// </summary>
/// <param name="targetType">The type of target (like buildings, open areas, vehicles).</param>
/// <returns>A list of weapons suitable for the specified target type.</returns>
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
