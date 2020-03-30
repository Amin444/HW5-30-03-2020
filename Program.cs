using System;

namespace HW_30._03._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1
           /* int a=3,b=18,e=0;
            for(int i=a;i<b;i++)
            {
                e+=i;
                    System.Console.WriteLine($"Все числа от A до В={e}");
            }
                    System.Console.WriteLine("---------------------------------------------------------------");
            for(int r=a;r<b;r++)
            {
                    e+=r;
                    if(e%2!=0)
                    {
                        System.Console.WriteLine($"Не четные числа={e}");
                    }
            }*/

                //Task 3========================================================================
                
                //Треугольник
               /* for(int i=0;i<15;i++)
                {
                    for(int z=0;z<i;z++)
                    {
                        System.Console.Write("* ");
                    }
                    System.Console.WriteLine();
                }*/

                //квадрат
              /*  for (int i = 0; i < 8 ; i++)
                {
                    for (int z = 0; z <= 15; z++)
                    {
                            System.Console.Write("*");
                    }
                    System.Console.WriteLine();
                }*/

                //Равнобедреный треугольник
               









               //Task 4
               
                while (true)
                {
                System.Console.WriteLine("Введите число р которая: 0<p<25!");
                    
               int p=int.Parse(Console.ReadLine());
               if (p>0&&p<25)
               {
                
               double sum=1000,Manth=0;
               
                 while(sum<=1100)
                 {
                    Manth++;
                    sum+=sum*p/100;
                 }
                 System.Console.WriteLine($"Manth={Manth}");
                 System.Console.WriteLine($"Sum={sum}");
                 
               }
               else
               {
                   System.Console.WriteLine("Вы ошиблись попробуйти еще раз :-0");
               }
                }
                    


                    Console.ReadKey();
               
            
                    
                
                    
                
        }
    }
}
