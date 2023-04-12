string input = "";
Console.WriteLine("Learn your squares and cubes!");

do
{
    Console.WriteLine();
    Console.WriteLine("Please enter a number");
    int num = int.Parse(Console.ReadLine()) + 1;
    if (num < 2 || num > 1290)
        Console.WriteLine("That number is too complicated for my computer brain to handle");
    else
    {
        Console.WriteLine();
        Console.WriteLine("Number  Squared  Cubed ");
        Console.WriteLine("======  =======  ======");
        for (int i = 1; i < num; i++)
        {
            int square = i * i;
            int cube = i * i * i;
            Console.WriteLine("{0, 2} {1, 7} {2, 10}", i, square, cube);
        }


    }
    Console.WriteLine();
    Console.WriteLine("Would you like to continue? y to continue, any other key to exit");
    input = Console.ReadLine();
    if (input != "y")
    {
       Console.WriteLine("Goodbye!");
    }
} while (input == "y");