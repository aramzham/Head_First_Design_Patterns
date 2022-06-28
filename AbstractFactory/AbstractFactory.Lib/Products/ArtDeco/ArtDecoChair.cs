namespace AbstractFactory.Lib.Products.ArtDeco;

public class ArtDecoChair : IAbstractChair
{
    public bool HasLegs()
    {
        return true;
    }

    public void SitOn()
    {
        // do something
    }

    // The variant, art deco chair, is only able to work correctly with the
    // variant, art deco table. Nevertheless, it accepts any instance of
    // AbstractProductA as an argument.
    public string AnotherUsefulFunction(IAbstractTable collaboratorTable)
    {
        var result = collaboratorTable.AnotherUsefulFunction();
        
        return $"The result of the {GetType().Name} collaborating with the ({result})";
    }
}