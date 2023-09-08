using System;

namespace Lab4Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercitiul1();
            //Exercitiul2();
            //Exercitiul3();
            //Exercitiul4();
            //Exercitiul5();
            //Exercitiul6();
            //Exercitiul7();
        }
        static void Exercitiul1()
        {
            /*Scrieti un program care va citi un vector de intregi de dimensiune n de la tastaura. Scrieti o
                functie care va inversa elementele vectorului, apelati-o si afisati-I rezultatul*/
            Console.WriteLine("dimnensiunea vectorului");
            int n = int.Parse(Console.ReadLine());
            int[] tabel = ReadArray(n);
            Invertarray(tabel);
            DisplayArray(tabel);




        }
        static void Exercitiul2()
        {
            /*Cititi de la tastatura continutul unei matrici de intregi cu 3 dimensiuni avand lungimile n, m
            k. Lungimile celor trei dimensiuni ale matricii, n, m si k, vor fi citite de la tastaura.
             Scrieti o functie care va calcula suma elementelor unei astfel de matrici , apelati-o si afisati-i
            rezultatul.
             Scrieti o functie care va determina elementul cu valoare maxima, apelati-o si afisati-i
            rezultatul*/
            Console.WriteLine("introduceit n:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("introduceit m:");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("introduceit i:");
            int i = int.Parse(Console.ReadLine());
            int[,,] mat1 = Read3dMatrix(n, m, i);
            //int[,,] mat2 = ReadMatrix(n, m,i);
            Show3dMatrix(mat1);
            Console.WriteLine(Matrix3dSum(mat1));
            Console.WriteLine(GetMax3d(mat1));
            //ShowMatrix(mat2);

        }
        static void Exercitiul3()
        {
            /*Cititi de la tastatura continutul a doua matrici de intregi cu 2 dimensiuni avand lungimile n
            m, respectiv m,n. Lungimile celor doua dimensiuni ale matricilor, m si n, vor fi citite de la
            tastaura. Scrieti o functie care va calcula produsul celor doua matrici, apelati-o si afisati-I
            rezultatul.*/
            Console.WriteLine("introduceit n:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("introduceit m:");
            int m = int.Parse(Console.ReadLine());
            int[,] mat1 = Read2dMatrix(n, m);
            int[,] mat2 = Read2dMatrix(m, n);
            Multiply2dMatrix(mat1, mat2);
            Show2dMatrix(Multiply2dMatrix(mat1, mat2));


        }
        static void Exercitiul4()
        {
            /*Scrieti o functie recursiva care va afisa in ordine elementele unui vector de
intregi.*/
            
            ReadArrayFactorial(new int[] { 1,2,3,4}, 0);

        }
        static void Exercitiul5()
        {
            /*Scrieti o functie recursiva care va calcula suma numerelor de la 1 pana la n,
apelati-o si afisati-i rezultatul. */
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(SumaRecursiva(n));
        }
        static void Exercitiul6()
        {
            /*Scrieti o functie recursiva care va calcula al n-lea element din sirul lui
Fibonacci, n fiind citit de la tastatura, apelati-o si afisati-I rezultatul.*/
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(GetFibonacci(n));
        }
        static void Exercitiul7()
        {
            /*Scrieti o functie recursiva care pentru un numar “n” primit ca parametru, va
afisa urmatoarea piramida a numerelor:
*/
            int n = int.Parse(Console.ReadLine());
              ShowPyramid(n);
        }
            
        static int[] ReadArray(int x)
        {
            int[] tabel = new int[x];
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("introdu elementul [:" + i + "]");
                tabel[i] = int.Parse(Console.ReadLine());
            }
            return tabel;
        }
        static void ReadArrayFactorial(int[]x, int index)
        {
            if (index >= x.Length)
            {
                return;
            }
            ReadArrayFactorial(x, index + 1);
            Console.WriteLine(x[index]);
           
            
        }
        static int SumaRecursiva(int n)
        {
            if (n <= 0)
            {
                return 0;
            }
            return n + SumaRecursiva(n - 1);
        }
        static int GetFibonacci( int n)
        {
            if(n < 1)
            {
                return 0;
            }
            if (n==1 || n ==2)
            {
                return 1;
            }
            return GetFibonacci(n-1) + GetFibonacci(n-2);
        }
        static void ShowPyramid(int n)
        {
            if(n <= 0 )
            {
                return ;
            }
            ShowPyramid(n - 1);
            for (int i = 0; i < n; i++)
            {
                Console.Write(n);
            }
            Console.WriteLine();
        }
        static int[] Invertarray(int[] x)
        {
            int n = x.Length;
            int[] aux = new int[n];
            for (int i = 0; i < n; i++)
            {
                aux[n - 1 - i] = x[i];
            }
            for (int i = 0; i < n; i++)
            {
                x[i] = aux[i];
            }
            return x;
        }

        static void DisplayArray(int[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {

                Console.WriteLine("elementul :[" + i + "]este: " + x[i] + "");
            }
        }
        static int[,,] Read3dMatrix(int n, int m, int l)
        {
            Console.WriteLine("introduceti matricea :");
            int[,,] result = new int[n, m, l];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    for (int k = 0; k < l; k++)
                    {
                        result[i, j, k] = int.Parse(Console.ReadLine());
                    }

            return result;
        }
        static int[,] Read2dMatrix(int n, int m)
        {
            Console.WriteLine("introduceti matricea :");
            int[,] result = new int[n, m];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)

                {
                    result[i, j] = int.Parse(Console.ReadLine());
                }

            return result;
        }

        static void Show3dMatrix(int[,,] matrix)
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);
            int l = matrix.GetLength(2);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    for (int k = 0; k < l; k++)
                    {
                        Console.Write(matrix[i, j, k] + " ");
                    }
                Console.Write("\n");
            }
        }
        static void Show2dMatrix(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)

                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.Write("\n");
            }
        }
        static int[,] Multiply2dMatrix(int[,]x, int[,]y)
        {
            int n = x.GetLength(0);
            int m = y.GetLength(1);
            int[,] prod = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    prod[i, j] = 0;
                    for (int k = 0; k < n; k++)
                    {
                        prod[i, j] += x[i, k] * y[k, j];
                    }
                }
            }
            return prod;
            }

        static int Matrix3dSum(int[,,]matrix)
        {
            int sum = 0;

            foreach (var element in matrix)
            {
                sum += element;
            }

            return sum;
        }
        static int GetMax3d(int [,,]  matrix) 
        {
            int max = 0;
            foreach (var element in matrix)
            {
                if  (max < element)
                {
                    max = element;
                }
            }

            return max;
        }


    }
}
