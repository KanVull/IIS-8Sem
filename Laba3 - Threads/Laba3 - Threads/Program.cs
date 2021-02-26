using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Laba3___Threads
{
    class Program
    {
        static int size = 10;
        static int printsize = 5;
        static int[,] a;
        static int[,] b;
        static int[,] c = new int[size, size];

        static int[,] GenerateMatrix()
        {
            int[,] matrix = new int[size, size];
            Random r = new Random();
            Thread.Sleep(60);
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    matrix[i, j] = r.Next(5);
            return matrix;
        }
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            a = GenerateMatrix();
            b = GenerateMatrix();

            c = mult(a, b);
            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
            Console.WriteLine(elapsedTime);
            Print(c);
            c = new int[size, size];
            stopwatch = new Stopwatch();
            stopwatch.Start();
            multThreads();
            stopwatch.Stop();
            ts = stopwatch.Elapsed;
            elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
            Console.WriteLine(elapsedTime);
            Print(c);
            Console.ReadKey();
        }

        static void Print(int[,] matrix)
        {
            byte t = 0;
            if (printsize < size) t = 1;
            for (int i = 0; i < printsize + t; i++)
            {
                for (int j = 0; j < printsize + t; j++)
                {
                    if (i == printsize)
                        Console.Write("...\t");
                    else
                        Console.Write("{0}\t", matrix[i, j]);
                    if (j == printsize) Console.Write("...\t");
                }
                Console.WriteLine();
            }
        }

        class Element
        {
            public int x = 0;
            public int y = 0;
        }

        static private void ComputeElement(Object el)
        {
            Element elem = (Element)el;
            for (int i = 0; i < size; i++)
            {
                c[elem.x, elem.y] += a[elem.x, i] * b[i, elem.y];
            }
        }

        static public int[,] multThreads()
        {
            Thread[,] th = new Thread[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Element elem = new Element();
                    elem.x = i;
                    elem.y = j;
                    th[i, j] = new Thread(new ParameterizedThreadStart(ComputeElement));
                    th[i, j].Start(elem);
                }
            }
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    th[i, j].Join();

            return c;
        }

        static public int[,] mult(int[,] a, int[,] b)
        {
            int[,] c = new int[size, size];
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    for (int k = 0; k < size; k++)
                        c[i, j] += a[i, k] * b[k, j];
            return c;
        }


    }
}
