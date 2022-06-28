using AbstractFactory.Lib.Products;

namespace AbstractFactory.Lib.Factories;

public interface IAbstractFactory
{
    IAbstractChair CreateChair();
    IAbstractTable CreateTable();
    IAbstractSofa CreateSofa();
}