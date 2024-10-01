using System;

class SomeClass
{
    // объявление константы подразумевает слово static !
    // после объявления константа немодифицируема 
    const int a = 2000;
    public readonly string s;
    //const string t = DateTime.Now.ToString(); // присваиваемое выражение не константа
    static int i = 100;
    public static int GetI()
    {
        return i;
    }
    public static void SetI(int k)
    {
        i = k;
    }
    public SomeClass()
    {
        Console.WriteLine("Конструктор по умолчанию");
        s = DateTime.Now.ToString();
    }
    static SomeClass()
    {
        Console.WriteLine("Введите число: ");
        i = Convert.ToInt32(Console.ReadLine());
    }
    public static int GetA()
    {
        return a;
    }
}

class Test
{
    static void Main()
    {
        SomeClass obj = new();
        Console.WriteLine(obj.s);
        Console.WriteLine(SomeClass.GetI());
        Console.WriteLine(SomeClass.GetA());
        SomeClass.SetI(5);
        Console.WriteLine(SomeClass.GetI());
        SomeClass.SetI(500);
        Console.WriteLine(SomeClass.GetI());
    }
}


