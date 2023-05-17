using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_number_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tansk 1:string concatonation
            string srt1 = "Hello ", str2 = "World!";
            Console.WriteLine(srt1 + str2);
            #region
            // Task 2:operations  for number 
            int number;
            Console.WriteLine("Введите любое челочисленное число");
            number = Convert.ToInt32(Console.ReadLine()); ;
            Console.WriteLine("Сложение: "+number + number);
            Console.WriteLine($"Вычитание: {number - number}");
            Console.WriteLine("Умножение: "+number * number);
            Console.WriteLine("Деление: "+number / number);
            Console.WriteLine("Деоение по модулю: "+number % number);
            #endregion
            #region
            //Task 3: 
            string firstName, lastName, patronymic;
            Console.WriteLine("Введите свое имя");
            firstName = Console.ReadLine();
            Console.WriteLine("Введите свою фамилию");
            lastName = Console.ReadLine();
            Console.WriteLine("Введите свое отчество");
            patronymic = Console.ReadLine();
            Console.WriteLine($"Привет {firstName}"+ $"{lastName}"+$"{patronymic}");
            #endregion
            //Task 4: little game
            #region
            Random rnd = new Random();
            int playerHp =200, monsterHp = 200;
            int playerDef = 5, monsterDef = 5;
            int playerDmg = rnd.Next(3,10), monsterDmg =rnd.Next(3,10) ;
            int monterGetDamage = playerDmg/monsterDef;
            int plaerGetDamage = monsterDmg/playerDef;
            Console.WriteLine("На вас напл монстр! Вы начали бой с ним.");
            while (playerHp > 0 && monsterHp > 0) 
            {
                Console.WriteLine("Вы атакуете монстра.");
                Console.WriteLine($"Здоровье монстра:{monsterHp-=monterGetDamage}");
                Console.WriteLine("Вас атакует вас.");
                Console.WriteLine($"Ваше здоровье: {playerHp-=plaerGetDamage}");
            }
            Console.ReadLine();

            #endregion

        }
    }
}
