using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHanoi
{
    class HanoiTower
    {
        // The maximum number of disks allowed in this tower
        // readonly means a constant value (meaning that you cannot change it after initialization)
        private readonly int maxDisks;

        // All the disks in this tower (stored in an array)
        public int[] Disks { get; private set; }

        // The current number of disks
        public int TowerCount
        {
            get;
        }

        // Check if the tower is empty or not
        public bool Empty
        {
            get;
        }
        // constructor
        public HanoiTower(int maxDisks)
        {
            this.maxDisks = maxDisks;
            Disks = new int[maxDisks];
        }

        // Insert all disks into this tower
        // for instance, if maxDisk = 5, Disks = {5, 4, 3, 2, 1}
        public void InsertAllDisks()
        {
            for (int i = 0; i < maxDisks; i++)
            {
                Disks[i] = i+1;
            }
        }

        // Insert a disk (with size diskSize) into this tower
        public void InsertDisk(int diskSize)
        {
            for (int i = maxDisks; i > 0; i--)
            {
                if (Disks[i-1] == 0)
                {
                    Disks[i-1] = diskSize;
                    break;
                }
            }
        }

        // Remove a disk from this tower (and return the disk's size)
        public int RemoveDisk()
        {
            int delSize = 0;

            for (int i = 0; i < maxDisks; i++)
            {
                if (Disks[i] != 0)
                {
                    delSize = Disks[i];
                    Disks[i] = 0;
                    break;
                }
            }

            return delSize;
        }
    }
}
