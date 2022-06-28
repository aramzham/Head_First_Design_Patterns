namespace AbstractFactory.Lib.Products.Victorian;

public class VictorianChair : IAbstractChair
{
    public bool HasLegs()
    {
        return true;
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