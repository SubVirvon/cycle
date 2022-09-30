using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cycle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string outputMessage;
            int iterationsCount;

            Console.WriteLine("Какое сообщение вы хотите вывести?");
            outputMessage = Console.ReadLine();
            Console.WriteLine("Какое количество раз вывести сообщение?");
            iterationsCount = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < iterationsCount; i++)
            {
                Console.WriteLine(outputMessage);
            }
            Console.ReadKey();
        }
    }
}
