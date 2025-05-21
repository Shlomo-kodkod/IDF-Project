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

    public override void Fire()
    {
        capacity -= 1;
        energySupply -= 13;
    }
}