class Car
{
    public string name;
}

class classOOPsClass2
{
    string model;
    string color;
    int year;
    static void Main(string[] args)
    {
        classOOPsClass2 Opel = new classOOPsClass2();
        classOOPsClass2 Ford = new classOOPsClass2();
        Car myObj = new Car();
        myObj.name = "Likhon";
        Ford.model = "Mustang";
        Ford.color = "red";
        Ford.year = 1969;

        Opel.model = "Astra";
        Opel.color = "white";
        Opel.year = 2005;

        Console.WriteLine(Ford.model);
        Console.WriteLine(Opel.model);
        Console.WriteLine(myObj.name);
    }
}