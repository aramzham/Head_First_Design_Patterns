using AbstractFactory.Lib.Products;
using AbstractFactory.Lib.Products.Victorian;

namespace AbstractFactory.Lib.Factories;

public class VictorianFactory : IAbstractFactory
{
    public IAbstractChair CreateChair()
    {
        return new VictorianChair();
    }

    public IAbstractTable CreateTable()
    {
        return new VictorianTable();
    }

    public IAbstractSofa CreateSofa()
    {
        return new VictorianSofa();
    }
}