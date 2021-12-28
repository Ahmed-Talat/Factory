namespace Factory;

public abstract class VechileFactory
{
    public abstract IVechile CreateVechile();
    public IVechile GetVechile()
    {
        var vechile = CreateVechile();
        return vechile;
    }
}
