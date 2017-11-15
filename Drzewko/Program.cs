using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drzewko
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Tree<int> t = null;
            int range = 20;
            string unsortedData = "";

            for (int i = 0; i < range; i++)
            {
                int value = r.Next(0, 100);

                if (t == null)
                {
                    t = new Tree<int>(value);
                }
                else
                {
                    t.InsertNode(value);
                }
                unsortedData += $"{value} ";
            }

            Console.WriteLine($"Unsorted data: {unsortedData}");
            Console.WriteLine($"Sorted using binary tree: {t.WalkTree()}");
            Console.ReadLine();

        }
    }
}
