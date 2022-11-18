namespace DataTypesAndVariables;

class Program
{
    static void Main(string[] args)
    {
        // declaring multiple variables at once
        int num3, num4, num5;

        // declaring a variable
        int num1;
        // assingning a value to a variable
        num1= 10;

        // declaring and initalizing a variable in one go
        int num2= 20;

        int sum = num1+ num2;
        Console.WriteLine(sum);

        double d1 = 3.1415;
        double d2 = 5.1;
        double dDiv = d1/ d2;
        Console.WriteLine($"d1/d2 is {dDiv}");

        float f1 = 3.1415f;
        float f2 = 5.1f;
        float fDiv = f1 / f2;
        Console.WriteLine($"d1/d2 is {fDiv}");


        Console.ReadLine();
    }
}
