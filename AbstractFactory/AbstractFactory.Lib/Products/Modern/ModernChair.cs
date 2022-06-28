namespace AbstractFactory.Lib.Products.Modern;

public class ModernChair : IAbstractChair
{
    public bool HasLegs()
    {
        return false;
    }

    public void SitOn()
    {
        // do something
    }

    public string AnotherUsefulFunction(IAbstractTable collaboratorTable)
    {
        var result = collaboratorTable.AnotherUsefulFunction();
        
        return $"The result of the {GetType().Name} collaborating with the ({result})";
    }
}