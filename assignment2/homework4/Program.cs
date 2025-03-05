using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> matrix = new List<List<int>>();
            

            bool test = true;
            for(int i = 0; i < matrix.Count-1; i++)
            {   
                for(int j = 0; j < matrix[i].Count; j++)
                {
                    if (matrix[i][j]!= matrix[i + 1][j + 1])
                    {
                        test = false;
                        break; 
                    }
                }
            }

        }
    }
}
