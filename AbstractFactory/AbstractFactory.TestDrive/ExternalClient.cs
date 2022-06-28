using AbstractFactory.Lib.Factories;

namespace AbstractFactory.TestDrive;

public class ExternalClient
{
    private readonly IAbstractFactory _factory;

    public ExternalClient(IAbstractFactory factory)
    {
        _factory = factory;
    }

    public string GetResult()
    {
        var chair = _factory.CreateChair();
        var table = _factory.CreateTable();
        var sofa = _factory.CreateSofa();
        return sofa.AnotherUsefulFunction(chair, table);
    }
}