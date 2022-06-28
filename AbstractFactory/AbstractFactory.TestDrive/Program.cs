// See https://aka.ms/new-console-template for more information

using AbstractFactory.Lib.Factories;
using AbstractFactory.TestDrive;

Console.WriteLine("Hello, World!");

var artDecoFactory = new ArtDecoFactory();
var client = new ExternalClient(artDecoFactory);

var victorianFactory = new VictorianFactory();
var anotherClient = new ExternalClient(victorianFactory);

Console.WriteLine(client.GetResult());
Console.WriteLine(new string('-', 20));
Console.WriteLine(anotherClient.GetResult());