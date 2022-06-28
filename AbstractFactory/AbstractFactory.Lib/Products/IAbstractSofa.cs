namespace AbstractFactory.Lib.Products;

public interface IAbstractSofa
{
    bool IsSoft();
    string AnotherUsefulFunction(IAbstractChair chair, IAbstractTable table);
}