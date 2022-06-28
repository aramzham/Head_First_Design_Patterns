using AbstractFactory.Lib.Products;
using AbstractFactory.Lib.Products.ArtDeco;

namespace AbstractFactory.Lib.Factories;

public class ArtDecoFactory : IAbstractFactory
{
    public IAbstractChair CreateChair()
    {
        return new ArtDecoChair();
    }

    public IAbstractTable CreateTable()
    {
        return new ArtDecoTable();
    }

    public IAbstractSofa CreateSofa()
    {
        return new ArtDecoSofa();
    }
}