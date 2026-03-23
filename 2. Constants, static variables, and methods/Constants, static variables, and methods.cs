using System;
using System.Text;

// Статичні члени класу (static members) у C# — це змінні, методи або властивості,
// які належать самому класу, а не окремому об’єкту.
// Якщо звичайні члени — це «для кожного об’єкта окремо»,
// то статичні — це «одне спільне для всіх».
class SomeClass
{
    // Оголошення константи передбачає слово static. 
    // Після оголошення константа немодифікується.
    const int a = 2000;
    public readonly string s;

    // Помилка компіляції: поточна дата невідома на етапі компіляції
    // const string t = DateTime.Now.ToString(); 

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
        Console.WriteLine("Конструктор за замовчуванням");
        s = DateTime.Now.ToString();
    }

    // Статичний конструктор (static constructor) у C# —
    // це спеціальний конструктор, який виконується один раз для всього класу,
    // щоб ініціалізувати статичні дані.
    // Це «автоматичний запуск коду», який:
    //     - виконується тільки 1 раз
    //     - запускається перед першим використанням класу
    //     - використовується для налаштування static полів
    static SomeClass()
    {
        Console.WriteLine("Статичний конструктор");
        Console.WriteLine("Введіть число: ");
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
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;
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


