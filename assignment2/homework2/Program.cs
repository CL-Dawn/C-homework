using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            
            int maxnum = list[0],minnum= list[0];
            double average = 0, total = 0;
            foreach (int i in list)
            {
                maxnum = Math.Max(maxnum,i);
                minnum = Math.Min(minnum,i);
                total += i;
            }
            average = total / list.Count;
        }
    }
}
