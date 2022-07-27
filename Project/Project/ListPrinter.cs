using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class ListPrinter
    {
        public static void PrintList<T>(GenericList<T> genericList)
        {
            try
            {
                for (int i = 0; i < 30; i++)
                {
                    Console.WriteLine(genericList.GetElementAt(i));
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                throw;
            }
        }
    }
}
