namespace AbstractFactory.Lib.Products.Modern;

public class ModernSofa : IAbstractSofa
{
    public bool IsSoft()
    {
        return false;
    }

    public string AnotherUsefulFunction(IAbstractChair chair, IAbstractTable table)
    {
        return $"{GetType().Name} produces other result:\n{chair.AnotherUsefulFunction(table)}";
    }
}