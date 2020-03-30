using System;

namespace ArrayTest
{
    class Program
    {
        class Arrs
        {
            private static Random rnd = new Random();

            public static void CreateOneDimAir(int[] arr)
            {
                for (int count = 0; count < arr.Length; count++)
                {
                    arr[count] = rnd.Next(1, 100);
                }
            }

            //задание 1.одномерные массивы.
            public static void PrintArr(string name, int[] arr)
            {
                Console.WriteLine("Массив " + name);

                for (int count = 0; count < arr.Length; count++)

                    Console.Write(arr[count] + " ");

                Console.WriteLine();
                Console.WriteLine();
            }

            //задание 2
            public static void CreateAr2(int[,] deb)
            {
                for (int count = 0; count < deb.GetLength(0); count++)
                    for (int count_1 = 0; count_1 < deb.GetLength(1); count_1++)
                        deb[count, count_1] = rnd.Next(1, 10);
            }
            
            //задание 2 
            //метод вывода матрицы
            public static void PrintArr2(int[,] ty, string name)
            {
                Console.WriteLine("Матрица " + name);

                for (int count = 0; count < ty.GetLength(0); count++, Console.WriteLine())
                {
                    for (int count_1 = 0; count_1 < ty.GetLength(1); count_1++)
                        Console.Write(ty[count, count_1].ToString().PadLeft(3));
                }

                Console.WriteLine();
            }


            //задание 2. многомерные массивы
            //функция которая возвращает результат перемножения двух матриц
            public static int[,] MultMatr(int[,] A, int[,] B)
            {
                int[,] empty = new int[0, 0];

                int[,] c = new int[A.GetLength(0), B.GetLength(1)];

                if (A.GetLength(0) != B.GetLength(1))
                {
                    Console.WriteLine("Умножение невозможно, возвращен пустой массив");

                    return empty;
                }
                else
                    for (int count = 0; count < c.GetLength(0); count++)
                        for (int count_1 = 0; count_1 < c.GetLength(1); count_1++)

                            //возвращаем массив который равен перемноженным массивам а и в
                            c[count, count_1] = A[count, count_1] * B[count, count_1];
                return c;
            }

            //задание 3
            public static void CreaterAr3(int[][] t)
            {
                for (int count = 0; count < t.Length; count++)
                    for (int count_1 = 0; count_1 < t[count].Length; count_1++)
                        t[count][count_1] = rnd.Next(1, 10);
            }

            //задание 3      
            public static void PrintAr3(int[][] z, string name)
            {
                Console.WriteLine("Массив " + name);

           
                for (int count = 0; count < z.Length; count++, Console.WriteLine())
                    for (int count_1 = 0; count_1 < z[count].Length; count_1++)
                        Console.Write(z[count][count_1] + " ");

                Console.WriteLine();
            }

            static void Main()
            {
                // Задание №1
                int[] A = new int[5];

                Arrs.CreateOneDimAir(A);

                int[] B = new int[5];
                Arrs.CreateOneDimAir(B);

                int[] C = new int[5];

                for (int count = 0; count < C.Length; count++)

                    //инициализируем значения суммы элементов массива а и в
                    C[count] = A[count] + B[count];

                //массив с явной инициализацией 
                int[] X = { 5, 5, 6, 6, 7, 7 };

                //массивы с отложенной инициализацией
                int[] U, V;

                //массив с тремя элементами со значениями от 1 до 3
                U = new int[3] { 1, 2, 3 };

                //массив для хранения трех элементов
                V = new int[3];

                //присваиваем каждому элементу массива v соответсвующий элемент массива u
                V = U;

                //изменяем значение первого элемента массива на 9
                V[0] = 9;

                Arrs.PrintArr("A", A);
                Arrs.PrintArr("B", B);
                Arrs.PrintArr("C", C);
                Arrs.PrintArr("X", X);
                Arrs.PrintArr("U", U);
                Arrs.PrintArr("V", V);

                Console.Write("Введите размерность массива: ");

                int size = int.Parse(Console.ReadLine());
                Console.WriteLine();

                //создаем массив с определенной длиной
                int[] D = new int[size];

                Arrs.CreateOneDimAir(D);
                Arrs.PrintArr("D", D);


                //Задание 2              
                int[,] M = new int[3, 3];
                int[,] N = new int[3, 3];

                Arrs.CreateAr2(M);
                Arrs.CreateAr2(N);

                Arrs.PrintArr2(M, "M");
                Arrs.PrintArr2(N, "N");

                Arrs.PrintArr2(MultMatr(M, N), "C");

                //Задание 3          
                int[][] R =
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
                    new int[10]
                };

               
                Arrs.CreaterAr3(R);

                
                Arrs.PrintAr3(R, "R");
            }
        }
    }
}