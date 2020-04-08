using System;

namespace Лаб2
{
    class Program
    {
        public static int kub(int a)
        {
            return a * a * a;
        }

        static void Main()
        {
            

            /*2.7
            int x = 10; int y = 5;
            int min = (x > y) ? y : x;
            Console.WriteLine(min);
            if(min/10>=1) Console.WriteLine("Da");
            else Console.WriteLine("Net");*/

            
            /* 2.8
            int a = 10, b = 3;
            int t = (a++) - b;
            // строка не будет выполненна, т.к переменная с именем b уже инициализирована
            int b+= (t * a); */


            /*д.з. 2.1
            int i, j, d = 0;
            Console.Write("Введите n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Введите k = ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("Введите m = ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Введите k1 = ");
            int k1 = int.Parse(Console.ReadLine());
            Console.Write("Введите m1 = ");
            int m1 = int.Parse(Console.ReadLine());
            //2.1.1.
            for (i = 1; i <= n; i++)//цикл матрицы шахматной доски
                for(j = 1; j <= n; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        d++;
                        //2.1.2
                        if ((k == i) && (m == j)) Console.WriteLine("Ячейка ({0} {1}) это черный цвет", k,m);
                    }

                    else 
                    {
                        if ((k == i) && (m == j)) Console.WriteLine("Ячейка ({0} {1}) это белый цвет", k, m); 
                    }
                }

            //2.1.3.
 
            if ((k + m) % 2 == (k1 + m1) % 2)
            {
                if ((k + m) % 2 == 0) Console.WriteLine("Ячейка ({0} {1}) и ячейка ({2} {3}) одного цвета - черного", k, m, k1, m1);
                else Console.WriteLine("Ячейка ({0} {1}) и ячейка ({2} {3}) одного цвета - белого", k, m, k1, m1);
            }
            else Console.WriteLine("Ячейка ({0} {1}) и ячейка ({2} {3}) разных цветов", k, m, k1, m1);
            //2.1.4.
             
            if (k + 1 == k1 && (m + 1 == m1 || m - 1 == m1)) Console.WriteLine("Фигура в ячейке ({0} {1}) находится под ударом Пешки в ячейке ({2} {3})", k, m, k1, m1);
            
            if ((k + m) % 2 == (k1 + m1) % 2 && (Math.Abs(k-m) == Math.Abs(k1 - m1 ) || k + m == k1 + m1)) Console.WriteLine("Фигура в ячейке ({0} {1}) находится под ударом Слона в ячейке ({2} {3})", k, m, k1, m1);
            
            if (k == k1 || m == m1)  Console.WriteLine("Фигура в ячейке ({0} {1}) находится под ударом Ладьи в ячейке ({2} {3})", k, m, k1, m1);
            
            if ((k == k1 || m == m1) || ((k + m) % 2 == (k1 + m1) % 2 && (Math.Abs(k - m) == Math.Abs(k1 - m1) || k + m == k1 + m1))) Console.WriteLine("Фигура в ячейке ({0} {1}) находится под ударом Ферзя в ячейке ({2} {3})", k, m, k1, m1);
            
            if (((k1 + 1 == k || k1 - 1 == k) && (m1 + 2 == m || m1 - 2 == m)) ||((k1 + 2 == k || k1 - 2 == k) && (m1 + 1 == m || m1 - 1 == m))) Console.WriteLine("Фигура в ячейке ({0} {1}) находится под ударом Коня в ячейке ({2} {3})", k, m, k1, m1);
            Console.WriteLine("Всего черных ячеек = {0}", d);  */


            
           /* д.з. 2.2
           int day, month, year , prosh = 0, osta = 0, predd = 0, predm = 0, predy = 0, nextd = 0, nextm = 0, nexty = 0;
           int[] d = {0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
           Console.WriteLine("Введите день ");
           day = int.Parse(Console.ReadLine());
           Console.WriteLine("Введите месяц ");
           month = int.Parse(Console.ReadLine());
           Console.WriteLine("Введите год ");
           year = int.Parse(Console.ReadLine());
           int m = month;

           //2.2.1 
           while (m > 0)
           {
              
               prosh = prosh + d[m];
               m--;
           }

           m = month;
           //2.2.2 
           while (m < 13)
           {
               
               osta = osta + d[m];
               m++;
           }
           // 2.2.3
           
           if(day == 1)
           {
               if (month == 1)
               {
                   predm = 12;
                   predy = year - 1;
                   predd = d[predm];
               }
               else 
               //если месяц не первый
               {
                  
                   predm = month - 1; 
                   predy = year;
               }
           }
           //если день не первый
           else
           {
               predd = day -1;
               predm = month;
               predy = year;
           }

           //2.2.4. 
           if (day == d[month])
           {
               
               if (month == 12)
               {
                   
                   nextd = 1;
                   nextm = 1;
                   nexty = year + 1;
               }
               else
               
               {
                   nextd = 1;
                   nextm = month + 1;
                   nexty = year;
               }
           }
           else
          
           {
               nextd = day + 1;
               nextm = month;
               nexty = year;
           }
           
           prosh = prosh - d[month];
           osta = osta - day; 
           Console.WriteLine("С начала года прошло {0} дней", prosh);
           Console.WriteLine("До конца года осталось {0} дней", osta);
           Console.WriteLine("Вчерашняя дата - {0}:{1}:{2}", predd, predm, predy);
           Console.WriteLine("Завтрашняя дата - {0}:{1}:{2}", nextd, nextm, nexty); */




            /* д.з. 2.3
           int first = 0, second = 0, third = 0 , armstrong;
             
           for (int i = 100; i < 1000; i++)
           {
               first = i % 10;
               second = (i / 10) % 10;
               third = (i / 100) % 10;
               armstrong = kub(first) + kub(second) + kub(third);
               if (armstrong == i) Console.WriteLine("{0} - число Армстронага", i);
           } */



            /* д.з. 2.4
            int visota, dlina;

            Console.WriteLine("Введите длинну прямоугольника");
            dlina = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите высоту прямоугольника");
            visota = int.Parse(Console.ReadLine());
            int S = visota * dlina;
            //мин кол во квадратов
            int minK = S;
            int maxK = 0;

            while(S > 1)
            {
              if (visota < dlina)
                {
                    dlina = dlina - visota;
                    S = S - visota * visota;
                    maxK++;
                }

                if(dlina < visota)
                {
                    visota = visota - dlina;
                    S = S - dlina * dlina;
                    maxK++;
                }
            }

            Console.WriteLine("В ваш прямоугольник помещается {0} квадратов минимальной площади", minK);
            // макс кей + 1 нужно для того чтобы учесть последний "прямоугольник" со сторонами 1 на 1
            Console.WriteLine("В ваш прямоугольник помещается {0} квадратов максимальной площади", maxK + 1); */



            /* к1.9
           int v = 12;
           double a;
           a = Math.Pow(v, 1.0/3);
           Console.WriteLine("Ребро куба равно = {0:#.###}", a);*/

            /*Zad к2. 1 и 2.
            int i = 22;
            if (i % 2 == 1) Console.WriteLine("nechet");
            else Console.WriteLine("chet");*/



            /*k3.11 
            Console.Write("x = ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("y = ");
            double y = double.Parse(Console.ReadLine());
            // здесь с поомощью оператора && задается диапазон значений х и y
            if ((x > -50 && x < 50) && (y > -25 && y < 25))
                Console.WriteLine("Внутри");
            // здесь с помощью оператора || задаются значения "на границе"
            else if ((x == -50 || x == 50) && (y == -25 || y == 25)) 
                Console.WriteLine("На границе");
            else Console.WriteLine("Не внутри");*/



            /* k4.1
           Console.Write("Введите месяц ");
           int n = int.Parse(Console.ReadLine());
           switch (n)
           {
               case 1: Console.WriteLine("До конца года осталось 11 месяцев"); break;
               case 2: Console.WriteLine("До конца года осталось 10 месяцев"); break;
               case 3: Console.WriteLine("До конца года осталось 9 месяцев"); break;
               case 4: Console.WriteLine("До конца года осталось 8 месяцев"); break;
               case 5: Console.WriteLine("До конца года осталось 7 месяцев"); break;
               case 6: Console.WriteLine("До конца года осталось 6 месяцев"); break;
               case 7: Console.WriteLine("До конца года осталось 5 месяцев"); break;
               case 8: Console.WriteLine("До конца года осталось 4 месяцев"); break;
               case 9: Console.WriteLine("До конца года осталось 3 месяцев"); break;
               case 10: Console.WriteLine("До конца года осталось 2 месяцев"); break;
               case 11: Console.WriteLine("До конца года осталось 1 месяцев"); break;
               case 12: Console.WriteLine("До конца года осталось 0 месяцев"); break;
               default: Console.WriteLine("error"); break;
           } */


            /* k5
            Console.Write("Введите курс = ");
            double n = double.Parse(Console.ReadLine());
            double kurs = 0;
            Console.WriteLine("while: ");
            double i = 5;
            while (i <= 120)
            {
                kurs = n * i; 
                Console.Write("{0}USD = {1}RUB \n", i,kurs);
                i += 5;
            }
            Console.WriteLine();

            Console.WriteLine("do while: ");
            i = 5;
            do
            {
                kurs = n * i;
                Console.Write("{0}USD = {1}RUB \n", i, kurs);
                i += 5;
            }
            while (i <= 120);
            Console.WriteLine();

            Console.WriteLine("For: ");
            for (i = 5; i <= 120; i += 5)
            {
                kurs = n * i;
                Console.Write("{0}USD = {1}RUB \n", i, kurs);
            } */



            // k6.20
             
            for (int i=10; i>=1; i--, Console.WriteLine())
            {
                if (i % 2 == 0)
                {
                    for (int j = 1; j <= i / 2; j++)
                        Console.Write("{0}   ", 2);
                }
                else
                {
                    for (int j = -1; j < i / 2; j++)
                        Console.Write("{0}   ", i/2+j);
                } 
            } 


        }
    }
}
