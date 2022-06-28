namespace AbstractFactory.Lib.Products.Victorian;

public class VictorianSofa : IAbstractSofa
{
    public bool IsSoft()
    {
        return true;
    }

    public string AnotherUsefulFunction(IAbstractChair chair, IAbstractTable table)
    {
        return $"This a perfect combination of furniture:\n{GetType().Name} + \n{chair.AnotherUsefulFunction(table)}";
    }
}