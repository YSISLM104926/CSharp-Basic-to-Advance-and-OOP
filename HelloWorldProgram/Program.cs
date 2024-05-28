class Program
{
    public static void Main(string[] args)
    {
        int myInt = 10;
        double myDouble = 5.25;
        bool myBool = true;

        Console.WriteLine(Convert.ToString(myInt));    // convert int to string
        Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
        Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
        Console.WriteLine(Convert.ToString(myBool));   // convert bool to string
                                                       // Type your username and press enter
        Console.WriteLine("Enter username:");

        // Create a string variable and get user input from the keyboard and store it in the variable
        string userName = Console.ReadLine();

        // Print the value of the variable (userName), which will display the input value
        Console.WriteLine("Username is: " + userName);

        string firstName = "John";
        string lastName = "Doe";
        string name = $"My full name is: {firstName} {lastName}";
        Console.WriteLine(name);
        int i = 0;
        while (i < 5)
        {
            Console.WriteLine(i);
            i++;
        }

        for (int k = 0; k <= 10; k = k + 2)
        {
            Console.WriteLine(k);
        }

        string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
        foreach (string f in cars)
        {
            Console.WriteLine(f);
        }

        int e = 0;
        while (e < 10)
        {
            Console.WriteLine(e);
            e++;
            if (e == 4)
            {
                break;
            }
        }

        // Sort a string
        string[] ca = { "Volvo", "BMW", "Ford", "Mazda" };
        Array.Sort(ca);
        foreach (string g in ca)
        {
            Console.WriteLine(g);
        }


        int[] myNumbers = { 5, 1, 8, 9 };
        Console.WriteLine(myNumbers.Max());  // returns the largest value
        Console.WriteLine(myNumbers.Min());  // returns the smallest value
        Console.WriteLine(myNumbers.Sum());  // returns the sum of elements

        int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };
        Console.WriteLine(numbers[0, 2]);  // Outputs 2

        int[,] number = { { 1, 4, 2 }, { 3, 6, 8 } };
        numbers[0, 0] = 5;  // Change value to 5
        Console.WriteLine(number[0, 0]); // Outputs 5 instead of 1


        int[,] num = { { 1, 4, 2 }, { 3, 6, 8 } };

        foreach (int ii in num)
        {
            Console.WriteLine(ii);
        }

        int[,] nu = { { 1, 4, 2 }, { 3, 6, 8 } };

        for (int p = 0; p < nu.GetLength(0); p++)
        {
            for (int u = 0; u < nu.GetLength(1); u++)
            {
                Console.WriteLine(nu[p, u]);
            }
        }

    }
}