class Program
{
    enum Level
    {
        Low,
        Medium,
        High
    }
    enum Months
    {
        January,    // 0
        February,   // 1
        March,      // 2
        April,      // 3
        May,        // 4
        June,       // 5
        July        // 6
    }

    enum Monthss
    {
        January,    // 0
        February,   // 1
        March = 6,    // 6
        April,      // 7
        May,        // 8
        June,       // 9
        July        // 10
    }

    static void Main(string[] args)
    {
        Level myVar = Level.Medium;
        Console.WriteLine(myVar);
        int myNum = (int)Months.April;
        Console.WriteLine(myNum);
        int myNums = (int)Monthss.April;
        Console.WriteLine(myNums);

        Level myVarr = Level.Medium;
        switch (myVarr)
        {
            case Level.Low:
                Console.WriteLine("Low level");
                break;
            case Level.Medium:
                Console.WriteLine("Medium level");
                break;
            case Level.High:
                Console.WriteLine("High level");
                break;
        }
    }
}