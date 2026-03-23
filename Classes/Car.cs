using System;

namespace CSharp.Classes
{
    // Первинні конструктори дозволяють додавати параметри визначення класу
    // і використовувати ці параметри всередині класу.
    // За кадром для кожного параметра первинного конструктора у класі
    // створюється приватне поле, що зберігає значення параметра.
    // Завдяки цьому вони можуть використовуватись у тілі класу.
    // Крім первинних конструкторів, клас може визначати додаткові конструктори.
    // Але ці додаткові конструктори мають викликати первинний конструктор.
    class Car(string driverName, int speed)
    {
        public Car() : this("Міхаель Шумахер", 0)
        {

        }
        public Car(string driverName) : this(driverName, 0)
        {
        }
        /*
        public Car(string driverName, int speed) // Головний конструктор
        {
            this.driverName = driverName;
            currSpeed = speed;
        }
        */
        public void SetDriver(string name) =>
            driverName = name;

        public void PrintState()		// Роздрук поточних даних
        {
            Console.WriteLine("{0} їде зі швидкістю {1} км/год.",
                driverName, speed);
        }   
        public void SpeedUp(int delta)	// Збільшення швидкості
        {
            speed += delta;
        }
    }

}
