using ControlObjectAccess.Lib;

var client = new Client();
            
Console.WriteLine("Client: Executing the client code with a real subject:");
var realSubject = new RealSubject();
client.ClientCode(realSubject);

Console.WriteLine();

Console.WriteLine("Client: Executing the same client code with a proxy:");
var proxy = new Proxy(realSubject);
client.ClientCode(proxy);