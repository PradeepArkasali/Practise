using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Advance_Concepts
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Delegate
            int[] values = { 1, 2, 3 };
            Util.Transform(values, Square);
            foreach (int i in values)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
            #endregion
        }

        static int Square(int x) => x * x;
    }
}
