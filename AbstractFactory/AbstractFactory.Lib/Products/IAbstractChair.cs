namespace AbstractFactory.Lib.Products;

public interface IAbstractChair
{
    bool HasLegs();
    void SitOn();
    // The Abstract Factory makes sure that all products it creates are of
    // the same variant and thus, compatible.
    string AnotherUsefulFunction(IAbstractTable collaboratorTable);
}