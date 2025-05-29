namespace IDF_Project;

public class Zik : StrikeOptions
{
    protected override string name { get; set; }
    protected override int capacity { get; set; }
    protected override int energySupply { get; set; }
    protected override string[] targetType { get; set; }

    public Zik()
    {
        name = "Zik drone";
        capacity = 3;
        energySupply = 100;
        targetType = new[] { "people", "vehicles" };
    }

/// <summary>
    /// Shoots a target by using one unit of ammo and 33% energy.
    /// </summary>
    public override void Fire()
    {
        capacity -= 1;
        energySupply -= 33;
    }

/// <summary>
    /// Returns a string with the drone's details.
    /// </summary>
    public override string ToString()
    {
        return $"Name : {name}, capacity : {capacity}, energySupply : {energySupply}%";
    }

/// <summary>
    /// Gets the number of shots remaining.
    /// </summary>
    /// <returns>Number of shots left in the drone.</returns>
    public override int GetCapacity()
    {
        return capacity;
    }

/// <summary>
    /// Gets the types of targets this drone can attack.
    /// </summary>
    /// <returns>string of target type names.</returns>
    public override string[] GettargetType()
    {
        return targetType;
    }
}