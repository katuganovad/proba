using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба4._1
{
   

        public class Fridge
        {
            string name;//производитель
            double currentT;//текущая температура
            double setT;//заданная температура
            double deviationT;//допустимое отклонение от заданной температуры
            double freezespeed;//скорость охлаждения
            double equalspeed;//скорость выравнивания температуры с окружающей средой
            double sredaT;//температура окружающей среды
            int hol;
            public Fridge(string name, double currentT, double setT, double deviationT, double freezespeed, double equalspeed, double sredaT)
            {
                hol++;
                this.name = name;
                this.setT = setT;
                Temper = currentT;
                this.deviationT = deviationT;
                SpeedF = freezespeed;
                SpeedS = equalspeed;
                this.sredaT = sredaT;
            }

            public string passport()
            {
                return string.Format($"Название холодильника: {name}\n" +
    
                    $"Текущая температура в камере холодильника: {currentT}\n" +
    
                    $"Заданная температура в камере холодильника: {setT}\n" +
    
                    $"Разрешенное отклонение от заданной температуры: {deviationT}\n" +
    
                    $"Скорость охлаждения: {freezespeed}\n" +
    
                    $"Скорость выравнивания температуры с окружающей средой: {equalspeed}\n" +
    
                    $"Температура окружающей среды: {sredaT}\n");
            }
            public void currentTempF()
            {
                Console.WriteLine("Текущая температура в холодильнике: " + currentT);
            }
            public void freezinTime(double time)//time-время, в течение которого необходимо охлаждать
            {
                double holodT = currentT - (freezespeed * time);
                if (holodT > (setT - deviationT))
                {
                    Temper = holodT;
                    Console.WriteLine("За время " + time + "произошло охлаждение до  " + currentT);
                }
                else
                {
                    Temper = setT;
                    Console.WriteLine("За время " + time + "произошло охлаждение до  " + currentT);
                }
            }
            public void waitingtime(double time)
            {
                double nagrevT = currentT + (equalspeed * time);
                if (nagrevT < sredaT)
                {
                    Temper = nagrevT;
                    Console.WriteLine("За время " + time + "произошло  нагревания до  " + currentT);
                }
                else
                {
                    Temper = sredaT;
                    Console.WriteLine("За время " + time + "произошло  нагревания до  " + currentT);
                }
            }
            public double Temper
            {   get { return currentT; }
                
                set { if ((value > sredaT) || (value < setT))
                {
                    Console.WriteLine("Вы ввелии невозможную температуру,  устновлено значение по умолчанию равное -2!");
                    currentT = -2;
                }
                else
                {
                    currentT = value;
                }
                }
            }
        public double SpeedF
        {
            get { return freezespeed; }

            set
            {
                if (value <= 0) 
                {
                    Console.WriteLine("Вы ввелии невозможную скорость охлаждения, устновлено значение по умолчанию равное 0.5!");
                    freezespeed=0.5;
                }
                else
                {
                    freezespeed = value;
                }
            }
        }
        public double SpeedS
        {
            get { return equalspeed; }

            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Вы ввелии невозможную скорость выравнивания, устновлено значение по умолчанию равное 2!");
                    equalspeed = 2;
                }
                else
                {
                    equalspeed = value;
                }
            }
        }
    }
    
}
