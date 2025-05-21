namespace IDF_Project;

public abstract class StrikeOptions
{
    protected abstract string name { get; set; }
    protected abstract int capacity{ get; set; }
    protected abstract int energySupply{ get; set; }
    protected abstract string[] targetType{ get; set; }
    
    protected abstract void Fire();

}