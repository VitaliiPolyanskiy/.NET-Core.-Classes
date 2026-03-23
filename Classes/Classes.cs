using CSharp.Classes;
using System;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

Console.WriteLine("Конструктор за замовчуванням");
Car myCar = new();
for (int i = 0; i <= 10; i++)
{
    myCar.SpeedUp(5);
    myCar.PrintState();
}

Console.WriteLine("\n\nКонструктор із параметрами");
myCar = new Car("Рубенс Барікелло");
for (int i = 0; i <= 10; i++)
{
    myCar.SpeedUp(5);
    myCar.PrintState();
}
