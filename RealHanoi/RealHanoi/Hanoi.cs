using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHanoi
{
    class Hanoi
    {
        // The three tower objects
        private HanoiTower[] towers = new HanoiTower[3];
        private int mycount =0;

        // Maximum number of disks in this Hanoi program
        public int NumOfDisks { get; private set; }

        // The current number of turns in the hanoi program
        public int Turns { get; private set; }

        // Constructor
        public Hanoi(int maxdisk)
        {
            NumOfDisks = maxdisk;

            towers[0] = new HanoiTower(NumOfDisks);
            towers[1] = new HanoiTower(NumOfDisks);
            towers[2] = new HanoiTower(NumOfDisks);
            towers[0].InsertAllDisks();
        }

        // Method to start the hanoi program
        public void Run()
        {
            Draw();
            Console.WriteLine("");
            ExecuteTurn(NumOfDisks, towers[0], towers[1], towers[2]);
            Console.WriteLine("Result: " + mycount);
        }

        // Execute a turn (recursive method) and draw the towers to the screen
        private void ExecuteTurn(int n, HanoiTower from, HanoiTower via, HanoiTower to)
        {
            if (n == 1)
            {
                to.InsertDisk(from.RemoveDisk());
                Draw();
                mycount++;
                Console.WriteLine("");
                
            }
            else
            {
                ExecuteTurn(n - 1, from, to, via);
                to.InsertDisk(from.RemoveDisk());
                Draw();
                mycount++;
                Console.WriteLine("");
                ExecuteTurn(n - 1, via, from, to);
            }
        }

        // Draw the hanoi tower and disks
        public void Draw()
        {
            for (int i = 0; i < NumOfDisks; i++)
            {
                DrawDisk(towers[0].Disks[i]);
                DrawDisk(towers[1].Disks[i]);
                DrawDisk(towers[2].Disks[i]);
                Console.WriteLine("");
            }
        }

        // Draw one disk (used in Draw() method)
        private void DrawDisk(int diskSize)
        {
            for (int i = 0; i < NumOfDisks*2 + 3; i++)
            {
                if (i < NumOfDisks - diskSize + 1 || i > NumOfDisks + 1 + diskSize)
                {
                    Console.Write(" ");
                }
                else if (i == NumOfDisks + 1)
                {
                    Console.Write("|");
                }
                else
                {
                    Console.Write("*");
                }
            }
        }
    }
}
