using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ASD_1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> w = new List<int>() { 1, 2, 3 }; // исходный список
            List<int> p = new List<int>(); // список перестановок
            List<int> w1 = new List<int>();
            int g = 0;
            Per(w, w1, p, g); // вызов рекурсивной функции
            Console.ReadKey();
        }
        static void Per(List<int> w, List<int> w1, List<int> p, int g)
        {
            if (g != w.Count)
            {
                p = w1.GetRange(0, w1.Count);
                w1.Clear();
                for (int i = 0; i < w.Count; i++)
                {
                    w1.Add(w[i]);
                    if (g != 0)
                        for (int j = 0; j < p.Count; j += g)
                        {
                            if (!w1.Contains(p[j]))
                                w1.Add(p[j]);
                        }
                }
                for (int i = 0; i < w1.Count; i+=g+1)
                {
                    if (i >= g)
                    {
                        for (int j = i; j >= i - g; j= j -1)
                        {
                            Console.Write(w1[j] + " ");
                        }
                        Console.WriteLine();
                    }
                }
                g += 1;
                Per(w, w1, p, g);
            }
        }
    }
}



