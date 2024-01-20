//Display a table of powers.
//Ask the user if they would like to go again,
//and if so loop back to the beginning.

while (true)
{
    Console.Write("Please enter an integer: ");

    if (int.TryParse(Console.ReadLine(), out int userInput) && userInput >= 1)
    {
        Console.WriteLine("{0, 7} {1,11} {2,9}", "Number", "Squared", "Cubed");
        Console.WriteLine("{0, -10} {1,0} {2, 10}", "========", "=========", "========");

        for (int i = 1; i <= userInput; i++)
        {
            int square = i * i;
            int cubed = i * i * i;
            Console.WriteLine("{0, 5} {1,8} {2, 2}", (i + "\t"), (square + "\t"), (cubed + "\t"));
        }
        Console.WriteLine("\nWould you like to restart (y/n)?");
        string loopChoice = Console.ReadLine().ToUpper();

        if (loopChoice == "Y")
        {
            Console.WriteLine("Restarting...");
            Thread.Sleep(1500);
            Console.Clear();
        }
        else if (loopChoice == "N")
        {
            Console.WriteLine("\nGoodbye!");
            break;
        }
        else
        {
            Console.WriteLine("\nThat wasn't y or n. Restarting anyway...");
            Thread.Sleep(1500);
            Console.Clear();
        }
    }
    else
    {
        Console.WriteLine("\nInvalid input. Please enter a valid number.");
        Thread.Sleep(1500);
        Console.Clear();
    }
}
