using AbstractFactory.Lib.Products;
using AbstractFactory.Lib.Products.Modern;

namespace AbstractFactory.Lib.Factories;

public class ModernFactory : IAbstractFactory
{
    public IAbstractChair CreateChair()
    {
        return new ModernChair();
    }

    public IAbstractTable CreateTable()
    {
        return new ModernTable();
    }

    public IAbstractSofa CreateSofa()
    {
        return new ModernSofa();
    }
}