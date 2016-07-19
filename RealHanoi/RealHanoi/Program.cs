using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the number of Disks");
            Hanoi hanoi = new Hanoi(int.Parse(Console.ReadLine()));
            hanoi.Run();
        }
    }
}
