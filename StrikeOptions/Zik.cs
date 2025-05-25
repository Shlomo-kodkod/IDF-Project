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

    public override void Fire()
    {
        capacity -= 1;
        energySupply -= 33;
    }
    public override string ToString()
    {
        return $" Mame : {name}, capacity : {capacity}, energySupply : {energySupply}%";
    }
    public override int GetCapacity()
    {
        return capacity;
    }
    public override string[] GettargetType()
    {
        return targetType;
    }
}