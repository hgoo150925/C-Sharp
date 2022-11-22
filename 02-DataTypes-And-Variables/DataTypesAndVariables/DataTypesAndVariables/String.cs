namespace DataTypesAndVariables;

class String
{
    static void Main(string[] args)
    {
        string myname = "Denis";

        string worldCup = "Qatar";

        Console.WriteLine($"My name is {myname}");
        Console.WriteLine($"Fifa World Cup {worldCup} 2022");

        string message = "this is a message";
        string capMessage = message.ToUpper();
        Console.WriteLine(capMessage);

        string lowerCaseMessage = $"Fifa World Cup {worldCup} 2022".ToLower();
        Console.WriteLine(lowerCaseMessage);
        
        Console.ReadLine();
    }
}

