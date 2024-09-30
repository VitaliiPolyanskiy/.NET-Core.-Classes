using System;

class SomeClass
{
    public int Count { get; set; }
    public string Name { get; set; }
    public static void OptArg(int a, int b = 20, int c = 30)
    {
        Console.WriteLine("a = {0}  b = {1}  c = {2}", a, b, c);
    }
}

class Test
{
    static void Main()
    {
        SomeClass obj = new() { Count = 100, Name = "Название" };
        Console.WriteLine(obj.Count + " " + obj.Name);
        SomeClass.OptArg(1, 2, 3);
        SomeClass.OptArg(1, 2);
        SomeClass.OptArg(1);
        SomeClass.OptArg(c: 300, a: 100, b: 200);
        SomeClass.OptArg(10, c: 100, b: 200);
        SomeClass.OptArg(10, c: 100);
        SomeClass.OptArg(10, b: 100);
    }
}


