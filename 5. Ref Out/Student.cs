using System;

namespace CSharp.Classes
{
    class Student(string _firstName, string _lastName, int _age, double _rating)
    {
        public void Show()
        {
            Console.WriteLine($"{_firstName}\t{_lastName}\t{_age}\t{_rating}");
        }

        // Деконструктори дозволяють виконати декомпозицію об'єкта деякі частини
        public void Deconstruct(out string firstName, out string lastName, out int age, out double rating)
        {
            firstName = _firstName;
            lastName = _lastName;
            age = _age;
            rating = _rating;
        }
    }
}
