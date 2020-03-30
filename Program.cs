using System;

namespace DZ5
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Задание №1\n Сделано :)");
                
            }
            {
                Console.WriteLine("Задание №2 первый пункт");
                int a, b;
                Console.Write("A = ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("B = ");
                b = Convert.ToInt32(Console.ReadLine());
                int sum = 0;
                for(int i=a+1; i<b; i++)sum += i;
                Console.WriteLine($"Сумма всех чисел расположенных между {a} и {b} = {sum}");
            }
            {
                Console.WriteLine("Задание №2 второй пункт");
                int a, b;
                Console.Write("A = ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("B = ");
                b = Convert.ToInt32(Console.ReadLine());
                for (int i = a+1; i<b; i++)if(i%2!=0) Console.Write($"{i} ");       
            }
           {
                Console.WriteLine("Задание №3 (прямоугольник)");
                Console.Write("Введите длину прямоугольника: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите ширину прямоугольника: ");
                int b = Convert.ToInt32(Console.ReadLine());
                for(int i=1; i<=a; i++)
                {
                    for(int j=1; j<=b; j++)
                    {
                       if ((i>1 && i<a) && (j>1 && j<b))Console.Write(" ");
                       else Console.Write("*");
                    }
                    Console.Write("\n");
                }
            }
           {
                Console.WriteLine("Прямоугольный треугольник: ");
                Console.Write("Введите длину катета: ");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = a + 1;
                for (int i=1; i<=a; i++)
                {
                    for (int j=1; j<=b; j++)
                    {
                        if (i>=1 && i==(j-1) && j<b) Console.Write("*");
                        if (i>=1 && j==1) Console.Write("*");
                        if (i==a) Console.Write("*");
                        else Console.Write(" ");  
                    }
                    Console.Write("\n");
                }
            }  
            {
                Console.WriteLine("Равносторонний треугольник ");
                Console.Write("Введите сторону равностороннего треугольника: ");
                int a = Convert.ToInt32(Console.ReadLine());
                int t = a;
                a = a*2+1;
                int ai=1;
                for (int i=1; i<=t+1; i++)
                {
                    for (int j=1; j<=a; j++)
                    {
                        if (i==1 && j==a/2+1) Console.Write("*");
                        if (i==ai && j==t+1-ai && i!=1) Console.Write("*");
                        if (i==ai && j==t+1+ai-1 && i!=1) Console.Write("*");
                        if (i==t && j%2>0 && j<a-1 && j!=1 && j!=a-2) Console.Write("*");
                        else Console.Write(" ");      
                    }
                    Console.Write("\n");
                    if(ai<t)ai++;   
                }  
            }
            {
                Console.WriteLine("Ромб");
                Console.Write("Введите сторону ромба: ");
                int a = Convert.ToInt32(Console.ReadLine());
                a = a-1;
                for (int i=a; i>=-a; i--)
                {
                    for (int j=1; j<=Math.Abs(i); j++)Console.Write(" ");
                    for(int k=a; k>=Math.Abs(i); k--)
                    {
                        Console.Write("*");
                        Console.Write(" ");
                    }
                    Console.Write("\n");
                }
            }    
            {
                Console.WriteLine("Задача №4");
                decimal nachVklad = 1000;
                Console.Write("P = ");
                decimal p =Convert.ToDecimal(Console.ReadLine());
                int k=0;
                do
                {
                    nachVklad =  nachVklad * (p / 100 + 1);
                    k++;
                }while (nachVklad <= 1100);
                Console.WriteLine($"k = {k} ");
                Console.WriteLine($"S = {nachVklad}");
            }
        }
    }   
}
