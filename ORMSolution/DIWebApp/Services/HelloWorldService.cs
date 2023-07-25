
using DIWebApp.Interfaces;

namespace DIWebApp.Services;

public class HelloWorldService:IHelloWorldService
{
	public HelloWorldService()
	{
		Console.WriteLine("HelloWorld Service instance Initialized....");
	}


	public string sayHello()
	{
		return "Wish you have a great career Opportunity";
	}
}
