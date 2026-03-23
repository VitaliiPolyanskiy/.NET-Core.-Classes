using System;
using System.Text;

class Student
{
    static int counter = 0;
    public Student()
    {
        Code = ++counter;
    }
    public int Age { get; set; }

    public int Code { get; } 

    public string Name { get; set; }
    public string Surname { get; set; }
    public double Average { get; set; }
}

class Person
{
    public string Name { get; set; } = "Петро";
    public int Age { get; set; } = 25;
}

class MainClass
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;
        Student[] st = new Student[2];
        for (int i = 0; i < st.Length; i++)
        {
            st[i] = new Student();
            Console.WriteLine("Введіть ім'я: ");
            st[i].Name = Console.ReadLine();
            Console.WriteLine("Введіть прізвище: ");
            st[i].Surname = Console.ReadLine();
            Console.WriteLine("Введіть вік: ");
            st[i].Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть середній бал: ");
            st[i].Average = Convert.ToDouble(Console.ReadLine());
            //st[i].Code = 100; // Властивість Code тільки для читання
        }
        for (int i = 0; i < st.Length; i++)
        {
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", st[i].Code, st[i].Name, st[i].Surname, st[i].Age, st[i].Average);
        }

        Person person = new();
        Console.WriteLine(person.Name);
        Console.WriteLine(person.Age);
    }
}
