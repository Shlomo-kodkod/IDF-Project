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

    public override void Fire()
    {
        capacity -= 1;
        energySupply -= 10;
    }
}