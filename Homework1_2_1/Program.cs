using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string message;
            int count;

            Console.Write("Введите сообщение, которое должно выводиться: ");
            message = Console.ReadLine();
            Console.Write("Введите, сколько раз Вы хотите чтобы оно выводилось: ");
            count = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(message);
            }
        }
    }
}