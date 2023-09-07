using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Холодильник";
            Console.WriteLine("Введите производителя");
            string name = Console.ReadLine();
            Console.WriteLine("Введите текущую температуру");
            double currentT = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите заданную температуру");
            double setT = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите допустимое отклонение от заданной температуры");
            double deviationT = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите скорость охлаждения");
            double freezespeed = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите скорость выравнивания температуры с окружающей средой");
            double equalspeed = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите температурe окружающей средой");
            double sredaT = Convert.ToDouble(Console.ReadLine());
            Fridge holod = new Fridge(name, currentT, setT, deviationT, freezespeed, equalspeed, sredaT);
            for (; ; )
            {
                Console.WriteLine("1 - Узнать текущую температуру в камере");
                Console.WriteLine("2 - Охлаждать в течении какого-то времени");
                Console.WriteLine("3 - Ожидать в течении какого-то времени");
                Console.WriteLine("4 - Изменить температуру холодильника с помощью свойств");
                Console.WriteLine("5 - Закончить работу");
                Console.WriteLine("Введите действие, которое необходимо выполнить: ");
                int dev = int.Parse(Console.ReadLine());
                switch (dev)
                {
                    case 1:
                        holod.currentTempF();
                        break;
                    case 2:
                        Console.WriteLine("Введите время охлаждения");
                        double time = Convert.ToDouble(Console.ReadLine());
                        holod.freezinTime(time);
                        break;
                    case 3:
                        Console.WriteLine("Введите время ожидания");
                        double time1 = Convert.ToDouble(Console.ReadLine());
                        holod.waitingtime(time1);
                        break;
                    case 4:
                        Console.WriteLine("Текущая температура холодильника {0} \n", currentT);
                        Console.WriteLine("устанавливаем новую температуру Т = {0} \n", -1); 
                        holod.Temper = -1;
                        Console.WriteLine("Изменённая температура холодильника {0} \n", holod.Temper);
                        Console.Read();

                        break;
                    case 5: 
                        holod.passport(); 
                        break;
                }
            }
        }
    }
}
