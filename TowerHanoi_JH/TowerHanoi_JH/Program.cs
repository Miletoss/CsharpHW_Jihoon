using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerHanoi_JH
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 4;
            ConsoleKeyInfo inchar;

            int[] towerA = {4, 3, 2, 0};
            int[] towerB = { 1, 0, 0, 0 };
            int[] towerC = { 0, 0, 0, 0 };

            PrintTowers(num, towerA, towerB, towerC);
            
        }

        static void PrintTowers(int n, int[] towerA, int[] towerB, int[] towerC)
        {
            for(int i = n; i>0; i--)
            {
                TowerCheck(i-1, towerA);
                TowerCheck(i-1, towerB);
                TowerCheck(i-1, towerC);
                Console.WriteLine();
            }
        }

        static void TowerCheck(int n, int[] arr)
        {
            switch (arr[n])
                {
                    case 0:
                        Console.Write("    |    ");
                            break;
                    case 1:
                        Console.Write("   *|*   ");
                        break;
                    case 2:
                        Console.Write("  **|**  ");
                        break;
                    case 3:
                        Console.Write(" ***|*** ");
                        break;
                    case 4:
                        Console.Write("****|****");
                        break;
                    default:
                        Console.WriteLine("ERR!");
                        break;
                }
        }
    }
}
