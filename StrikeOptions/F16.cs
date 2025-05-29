namespace IDF_Project;

public class F16 : StrikeOptions
{
    protected override string name { get; set; }
    protected override int capacity { get; set; }
    protected override int energySupply { get; set; }
    protected override string[] targetType { get; set; }

    protected string Opreitor;

    public F16()
    {
        name = "F16 Fighter Jet";
        capacity = 8;
        energySupply = 100;
        targetType = new[] {"buildings"};
        Opreitor = "pilot";
    }

/// <summary>
    /// Shoots a target by using one unit of ammo and 13% energy.
    /// </summary>
    public override void Fire()
    {
        capacity -= 1;
        energySupply -= 13;
    }
    
/// <summary>
    /// Returns a string with the jet's details.
    /// </summary>
    public override string ToString()
    {
        return $"Name : {name}, capacity : {capacity}, energySupply : {energySupply}%";
    }
    
/// <summary>
    /// Gets the number of shots remaining.
    /// </summary>
    /// <returns>Number of shots left in the jet.</returns>
    public override int GetCapacity()
    {
        return capacity;
    }

/// <summary>
    /// Gets the types of targets this jet can attack.
    /// </summary>
    /// <returns>string of target type names.</returns>
    public override string[] GettargetType()
    {
        return targetType;
    }


}