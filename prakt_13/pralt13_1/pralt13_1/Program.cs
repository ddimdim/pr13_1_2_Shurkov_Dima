using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace pralt13_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ArrayList list = new ArrayList() { "Петров", "Иванов", "Соболев", "Попов", "Шавкунов" };
                ArrayList list1 = new ArrayList() { "Ковязин", "Максим Кириллов", "Соколов", "Белоносов", "Полеев" };
                Console.WriteLine("Первоначальный список:");
                foreach (object print in list)
                {
                    Console.Write(print + " ");
                }
                Console.WriteLine();
                int n1 = 0;
                while (true)
                {
                    Console.WriteLine("Введите n");
                    n1 = int.Parse(Console.ReadLine());
                    if (n1 > list.Count || n1 < 0) Console.WriteLine("Число n не может быть меньше 0 и больше количества элементов в списке");
                    else break;
                }
                list.InsertRange(n1, list1);
                Console.WriteLine("Обновленный список");
                foreach (object print in list)
                {
                    Console.Write(print + " ");
                }
                Console.WriteLine();
                int n = n1 / 2;

                int k = 0;
                while (true)
                {
                    Console.WriteLine("Введите количество элементов k, которое хотите удалить");
                    k = int.Parse(Console.ReadLine());
                    if (k > list.Count || k < 0) Console.WriteLine("Число k не может быть меньше 0 и больше количества элементов в списке");
                    else break;
                }
                list.RemoveRange(n, k);
                Console.WriteLine("Список, после удаления элементов");
                foreach (object print in list)
                {
                    Console.Write(print + " ");
                }
            }
            catch
            {
                Console.WriteLine("Ошибка, неверный ввод данных");
            }
            
            Console.ReadKey();
        }
    }
}
