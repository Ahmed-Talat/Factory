namespace Factory;

public class TwoWheelerFactory : VechileFactory
{
    public override IVechile CreateVechile()
    {
        return new TwoWheeler();
    }
}
