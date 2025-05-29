namespace IDF_Project;

public class M109 : StrikeOptions
{
    protected override string name { get; set; }
    protected override int capacity { get; set; }
    protected override int energySupply { get; set; }
    protected override string[] targetType { get; set; }

    public M109()
    {
        name = "M109 Artillery";
        capacity = 40;
        energySupply = 100;
        targetType = new[] { "open areas" };
    }

/// <summary>
    /// Shoots a target by using one unit of ammo and 10% energy.
    /// </summary>

    public override void Fire()
    {
        capacity -= 1;
        energySupply -= 10;
    }

/// <summary>
    /// Returns a string with the artillery's details.
    /// </summary>
    public override string ToString()
    {
        return $"Name : {name}, capacity : {capacity}, energySupply : {energySupply}%";
    }
    
/// <summary>
    /// Gets the number of shots remaining.
    /// </summary>
    /// <returns>Number of shots left in the artillery.</returns>
    public override int GetCapacity()
    {
        return capacity;
    }
    
/// <summary>
    /// Gets the types of targets this artillery can attack.
    /// </summary>
    /// <returns>string of target type names.</returns>

    public override string[] GettargetType()
    {
        return targetType;
    }
}