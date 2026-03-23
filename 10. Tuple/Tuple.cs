using System;

//У C# кортеж (tuple) — це зручна структура даних,
//яка дозволяє об’єднати кілька значень (можливо різних типів)
//в один об’єкт без створення окремого класу.

var tuple = (7, 10);
Console.WriteLine(tuple.Item1);
Console.WriteLine(tuple.Item2);
Console.WriteLine(tuple.GetType().BaseType);
tuple.Item1 += 15;

(string, string, int) person = ("Jeffrey", "Richter", 61);
Console.WriteLine(person.Item1);
Console.WriteLine(person.Item2);
Console.WriteLine(person.Item3);

var student = (Name: "Anders", Surname: "Hejlsberg", Age: 25, Rating: 11.5);
Console.WriteLine(student.Name);
Console.WriteLine(student.Surname);
Console.WriteLine(student.Age);
Console.WriteLine(student.Rating);

var (Name, Age) = ("Petro", 18);
Console.WriteLine(Name);
Console.WriteLine(Age);

var range = (min: 0, max: 20);
int[] ar = new int[10];
var (sum, average) = GetValues(ar, range);
Console.WriteLine("Sum of array elements: " + sum);
Console.WriteLine("Average value of array elements: " + average);

static (int sum, double average) GetValues(int[] ar, (int min, int max) range)
{
    var rand = new Random();
    for (int i = 0; i < ar.Length; i++)
        ar[i] = rand.Next(range.min, range.max);
    var result = (sum: 0, average: 0.0);
    foreach (var item in ar)
    {
        result.sum += item;
    }
    result.average = result.sum / (double)ar.Length;
    return result;
}
