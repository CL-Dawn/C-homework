using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string recvData = Console.ReadLine();
            int topData=int.Parse(recvData);
            //计算素数因子
            List <int>listPrimeNumber = new List<int>();
            for(int i= 2; i < topData; i++)
            {
                listPrimeNumber.Add(i);
            }
            for(int i= 0;i < listPrimeNumber.Count; i++)
            {
                int nowPrimeNumber = listPrimeNumber[i];
                for(int j= i+1;j < listPrimeNumber.Count; j++)
                {
                    if (listPrimeNumber[j] %nowPrimeNumber == 0)
                    {
                        listPrimeNumber.RemoveAt(j);
                        j--;
                    }
                }
            }
            //输出所有素数因子
            //for(int i= 0; i<listPrimeNumber.Count; i++)
            //{
            //    Console.WriteLine($"{ listPrimeNumber[i]}");
            //}
            for (int i= 0; i < listPrimeNumber.Count; i++)
            {
                if (topData % listPrimeNumber[i] == 0)
                {
                    Console.WriteLine(listPrimeNumber[i]);
                }
            }

        }
    }
}
