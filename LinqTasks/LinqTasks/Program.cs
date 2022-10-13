using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] list = new int[10] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            
        }

        public List<int> EvenNumbers(int[] list)
        {

            List<int> result = new List<int>();
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] % 2 == 0)
                {
                    result.Add(i);
                }
            }

            return result;
            //cool stuff philipp did
            //return list.Where(e => e % 2 == 0).ToList();


        }

        
    }
}
