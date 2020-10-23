using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ваше имя ");
            var name = Console.ReadLine();
            Console.Write("Введите ваш возраст ");
            var age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ваше имя: {0}, возраст: {1}", name, age);
            Console.Write("Введите дату вашего рождения ");
            var birthdate = Console.ReadLine();
            Console.WriteLine("Дата вашего рождения: {0}", birthdate);
            


            Console.ReadKey();



            


            


        }
    }
}
