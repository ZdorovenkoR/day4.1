using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите фамилию");
            string firstName = Console.ReadLine();
            Console.WriteLine("Введите имя");
            string lastName = Console.ReadLine();
            Console.WriteLine("Введите отчетсво");
            string patronymic = Console.ReadLine();
            string fullName = GetFullName(firstName, lastName, patronymic);
            Console.WriteLine(fullName);
        }
        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            return $"{firstName} {lastName} {patronymic}";
        }
    }
}
