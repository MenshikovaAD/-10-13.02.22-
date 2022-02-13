using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_10__13._02._22_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите значение угла:");
            Console.WriteLine("Введите значение градусов:");
            int gradus_ = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение минут:");
            int min_ = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение секунд:");
            int sec_ = Convert.ToInt32(Console.ReadLine());
            Triangle triangle = new Triangle(gradus_, min_, sec_);
            double TotalRadians = triangle.ToRadians();
            Console.WriteLine("Значение угла в радианах - {0} ", Math.Round(TotalRadians, 3));
            Console.ReadKey();
        }
    }
    class Triangle
        {
            int gradus;
            int min;
            int sec;
            public int Gradus
            {
                set
                {
                    if (value<0)
                    {
                    Console.WriteLine("Значение не может быть отрицательным");
                }
                    if (value > 360)
                    {
                        Console.WriteLine("Значение градусов не может быть больше 360");
                    }
                else
                {
                    gradus = value;
                }

            }
                get
                {
                    return gradus;
                }

            }
            public int Min
            {
                set
                {
                    if (value <0)
                    {
                    Console.WriteLine("Значение не может быть отрицательным");
                }
                    if (value > 60)
                    {
                        Console.WriteLine("Значение минут не может быть больше 60");
                    }
                else
                {
                    min = value;
                }

            }
                get
                {
                    return min;
                }
            }
            public int Sec
            {
                set
                {
                    if (value <0)
                {
                    Console.WriteLine("Значение не может быть отрицательным");
                }
                    if (value > 60)
                    {
                        Console.WriteLine("Значение секунд не может быть больше 60");
                    }
                    else
                    {
                        sec=value;
                    }

                }
                get
                {
                    return sec;
                }
            }
            public Triangle(int gradus, int min, int sec)
            {
                this.Gradus = gradus;
                this.Min = min;
                this.Sec = sec;
            }

            public double ToRadians()
            {
                return (((gradus + ((min + sec / 60) / 60))) *  Math.PI/180) ;

            }
        
    }
}
