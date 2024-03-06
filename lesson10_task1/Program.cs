using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson10_task1
{
    class Angle
    {
        int gradus;
        int min;
        int sec;

        public Angle (int gradus, int min, int sec)
        {
            this.gradus = gradus;
            this.min = min;
            this.sec = sec;
        }

        public double ToRadians()
        {
            return (this.gradus + ((min + sec / 60) / 60))* Math.PI/180;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int gradus = 0, min = 0, sec = 0;
            Console.WriteLine("Введите градусы, минуты и секунды угла");
            try
            {
                gradus = Convert.ToInt32(Console.ReadLine());
                min = Convert.ToInt32(Console.ReadLine());
                sec = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            };

            Angle ang = new Angle(gradus, min, sec);
            Console.WriteLine("Начальные значения: {0} {1} {2}, радианы: {3}", gradus, min, sec, ang.ToRadians());
            Console.ReadKey();
        }
    }
}
