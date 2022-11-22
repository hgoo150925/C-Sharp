namespace DataTypesAndVariables;
class ImplicitAndExplicitConversion
{
    static void Main(string[] args)
    {
        // implicit conversion 
        int num = 12345678;
        long bigNum = num;


        double myDouble = 13.37;
        int myInt;

        // explicit conversion
        // cast double to int
        myInt = (int)myDouble;
        Console.WriteLine(myInt);
        Console.ReadLine();
    }
}


