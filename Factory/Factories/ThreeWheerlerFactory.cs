namespace Factory;

public class ThreeWheerlerFactory : VechileFactory
{
    public override IVechile CreateVechile()
    {
        return new ThreeWheeler();
    }
}
