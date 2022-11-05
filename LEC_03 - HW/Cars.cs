using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEC_03___HW
{
    internal class Cars
    {
        public const int Number1 = 3;

        public readonly int Number2 = 4;


        public Cars()
        {
            Number2 = int.Parse(Console.ReadLine());
        }

        public void Check()
        {
            Console.WriteLine($"\nYour Age Is: {Number2}\n");
            if (Number2 > 30)
            {
                Console.WriteLine($"{Number1}*{Number2} = {Number1 * Number2}");
            }
            else
            {
                Console.WriteLine($"{Number2}*20 = {Number2 * 20}");
            }
        }

    }
}
