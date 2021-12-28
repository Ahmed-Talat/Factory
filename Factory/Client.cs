namespace Factory;

public class Client
{
    private readonly IVechile _vechile;
    public Client(VechileFactory VechileFactory)
    {
        _vechile = VechileFactory.GetVechile();
    }
    public void fun()
    {
        _vechile.Print();
    }
}