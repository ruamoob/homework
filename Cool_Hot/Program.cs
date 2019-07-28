using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cool_Hot
{
    class Program
    {
        static void Main(string[] args)
        {            
            Random rnd = new Random();//Создание объекта для генерации чисел           
            int valueRandom = rnd.Next(100);  //Получить случайное число          
           // Console.WriteLine(valueRandom);   //Вывод полученного числа в консоль

            int valueUser;
            int result;      

            do
            {
               // Console.WriteLine("Введите число");
                String userInput;
                userInput = Console.ReadLine();
                valueUser = Int16.Parse(userInput);
                result = (valueUser - valueRandom);
                if (result < 0) result = result * -1;

                if (result > 10)
                {
                    Console.WriteLine("Холодно");               
                }
                if ((result <= 10) && (result != 0))
                {
                    Console.WriteLine("Горячо");                
                }
                if (result == 0)
                {
                    Console.WriteLine("Успех! Число угадано: " + valueRandom + " !");                          
                }
            }           
                while (valueUser != valueRandom) ;
                Console.ReadLine();
        }                
        }
    }

