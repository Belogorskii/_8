
/*Выберите любую папку на своем компьютере, имеющую вложенные директории. 
Выведите на консоль ее содержимое и содержимое всех подкаталогов.*/

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
            string path = @"C:\T";
            string[] files = Directory.GetFiles(path, "", SearchOption.AllDirectories);

            //если ввожу фармат файла ничего не выдает, это не в ходит в поставленную задачу просто
            //непонимаю почему не срабатывет программа верно
            //string[] files = Directory.GetFiles(path, "", SearchOption.AllDirectories);


            foreach (string file in files)
            {
                Console.WriteLine(file);
            }
            Console.ReadKey();
        }
    }
}


