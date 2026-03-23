using System;

// Починаючи з C# 6.0 у мові з'явився елвіс-оператор чи оператор умовного null (Null-Conditional Operator).
// Він дозволяє спростити перевірку об'єктів на значення null в умовних конструкціях.

namespace Null_Conditional_Operator
{
    class User
    {
        public string Name { get; set; }
        public Phone Phone { get; set; }
    }

    class Phone
    {
        public string Country { get; set; }
        public Company Company { get; set; }
    }

    class Company
    {
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            User user = new()
            {
                Name = "Tom",
                Phone = new Phone { Country = "South Korea", Company = new Company { Name = "Samsung" } }
            };

            string userName = user == null ? null : user.Name;
            if (userName != null)
                Console.WriteLine(userName);
            string country = user == null ? null : user.Phone == null ? null : user.Phone.Country;
            if (country != null)
                Console.WriteLine(country);
            string companyName = user == null ? null : user.Phone == null ? null : user.Phone.Company == null ? null : user.Phone.Company.Name;
            if (companyName != null)
                Console.WriteLine(companyName);


            if(user?.Name != null)
                Console.WriteLine(user.Name);
            if (user?.Phone?.Country != null)
                Console.WriteLine(user.Phone.Country);
            if (user?.Phone?.Company?.Name != null)
                Console.WriteLine(user.Phone.Company.Name);
        }
    }
}
