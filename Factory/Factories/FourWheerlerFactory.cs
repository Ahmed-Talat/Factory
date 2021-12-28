namespace Factory;

public class FourWheerlerFactory : VechileFactory
{
    public override IVechile CreateVechile()
    {
        return new FourWheeler();
    }
}
