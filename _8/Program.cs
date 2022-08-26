

/*Программно создайте текстовый файл и запишите в него 10 
случайных чисел. Затем программно откройте созданный файл, 
рассчитайте сумму чисел в нем, ответ выведите на консоль.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Test\Test.txt";
            Random random = new Random();
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                for (int i = 0; i < 5; i++)
                {
                    sw.WriteLine(random.Next(-5, 5));
                }
            }
            int sum = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                for (int i = 0; i < 10; i++)
                {
                    sum = sum + Convert.ToInt32(sr.ReadLine());
                }
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
