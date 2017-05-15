using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{

    class Arrs
    {
        static private Random rnd = new Random();

        static public int[] CreateOneDimAr(int[] m)
        {
            for (int i = 0; i >= 0 && i < m.GetLength(0); i++)
            {
                m[i] = rnd.Next(1,100);
            }
            return m;
        }

        static public int[,] CreateAr2(int[,] m)
        {
            for (int i = 0; i >= 0 && i < m.GetLength(0); i++)
            {
                for (int j = 0; j >= 0 && j < m.GetLength(0);j++ )
                    m[i, j] = rnd.Next(1, 10);
            }
            return m;
        }

        static public int[][] CreateAr3(int[][] m)
        {
            for (int i = 0; i >= 0 && i < m.Length; i++)
            {
                for (int j = 0; j >= 0 && j < m[i].GetLength(0); j++)
                    m[i][j] = rnd.Next(1, 10);
            }
            return m;
        }

        static public void PrintArr1(string name, int[] m)
        {
            Console.Write(name + " Массив: ");
            for (int i = 0; i >= 0 && i < m.GetLength(0); i++)
            {
                Console.Write(m[i] + " ");
            }
            Console.WriteLine();
        }

        static public void PrintArr2(string name, int[,] m)
        {
            Console.Write(name);
            for (int i = 0; i >= 0 && i < m.GetLength(0); i++)
            {
                for (int j = 0; j >= 0 && j < m.GetLength(0); j++)
                { 
                    Console.Write(m[i, j] + " \t"); 
                }
                Console.WriteLine();
            }
            Console.WriteLine();            
        }

        static public void PrintArr3(string name, int[][] m)
        {
            Console.Write(name);
            for (int i = 0; i >= 0 && i < m.GetLength(0); i++)
            {
                for (int j = 0; j >= 0 && j < m[i].GetLength(0); j++)
                {
                    Console.Write(m[i][j] + " \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }


        static public int[,] MultMatr(int[,] a, int[,] b)
        {
            int aget = a.GetLength(0);
            int bget = b.GetLength(0);
            int[,] error = new int[0,0];
            int[,] ab = new int[aget,bget];
            if (aget == bget)
            {
                for (int i = 0; i >= 0 && i < aget; i++)                    
                {
                    for (int j = 0; j>=0 && j < bget; j++)
                    {
                        ab[i,j] = a[i,j] * b[i,j];     
                    }                                          
                }
                return ab;
            }
            else return error;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {/*
            int[] A = new int[5], B = new int[5], C = new int[5];
            A = Arrs.CreateOneDimAr(A);
            B = Arrs.CreateOneDimAr(B);

            for (int i = 0; i >= 0 && i < C.GetLength(0); i++)
            {
                C[i] = A[i] + B[i];
            }

            int[] X = { 5, 5, 6, 6, 7, 7 };
            int[] U, V;
            U = new int[3] { 1, 2, 3 };
            //V = {1,2,3}; константный массив/ V ссылается на блок памяти, инициализации не было
           
            V = new int[3];
            V = U;
            V[1] = 9;

            Arrs.PrintArr1("A", A);
            Arrs.PrintArr1("B", B);
            Arrs.PrintArr1("C", C);
            Arrs.PrintArr1("X", X);
            Arrs.PrintArr1("U", U);
            Arrs.PrintArr1("V", V);

            Console.WriteLine("Введите размерность массива:");
            int size = int.Parse(Console.ReadLine());
            int[] D = new int[size];
            Arrs.CreateOneDimAr(D);
            Arrs.PrintArr1("D", D);
            
            //2 задание
            Console.WriteLine("Введите размерность массива 1:");            
            int raz1i = int.Parse(Console.ReadLine());            
            int[,] mat1 = new int[raz1i, raz1i];

            Console.WriteLine("Введите размерность массива 2:");
            int raz2i = int.Parse(Console.ReadLine());            
            int[,] mat2 = new int[raz2i,raz2i];

            int[,] mat3 ;

            mat1 = Arrs.CreateAr2(mat1);
            mat2 = Arrs.CreateAr2(mat2);
            mat3 = Arrs.MultMatr(mat1, mat2);

            Arrs.PrintArr2("Первая матрица \n", mat1);
            Arrs.PrintArr2("Вторая матрица \n", mat2);
            Arrs.PrintArr2("Умножение \n", mat3);
*/
            //3 задание
            int[][] R = new int[10][]
            {
                new int[1],
                new int[2],
                new int[3],
                new int[4],
                new int[5],
                new int[6],
                new int[7],
                new int[8],
                new int[9], 
                new int[10], 
                             
            };
            Arrs.CreateAr3(R);
            Arrs.PrintArr3("Массив массивов: \n\n",R);

        }
    }
}