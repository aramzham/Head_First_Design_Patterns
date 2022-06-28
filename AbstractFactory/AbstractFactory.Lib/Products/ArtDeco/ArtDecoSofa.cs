namespace AbstractFactory.Lib.Products.ArtDeco;

public class ArtDecoSofa : IAbstractSofa
{
    public bool IsSoft()
    {
        return true;
    }

    public string AnotherUsefulFunction(IAbstractChair chair, IAbstractTable table)
    {
        return
            $"Here is the result of collaboration of {GetType().Name} with other entities:\n{chair.AnotherUsefulFunction(table)}";
    }
}