using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2
{
    struct Train
    {
        private string place;

        private int numberTrain;

        private DateTime time;
        public string Place { get => place; set => place = value; }
        public int NumberTrain { get => numberTrain; set => numberTrain = value; }
        public DateTime Time { get => time; set => time = value; }

        public Train(string place, int numberTrain, DateTime time)
        {
            this.place = place;
            this.numberTrain = numberTrain;
            this.time = time;
        }

        
    }

    class Program
    {
        static void Main(string[] args)
        {
            Train[] train = new Train[8];
            train[0] = new Train("Minsk", 125, DateTime.Now);
            train[1] = new Train("Brest", 126, DateTime.Now);
            train[2] = new Train("Vitebsk", 245, DateTime.Now);
            train[3] = new Train("Polock", 542, DateTime.Now);
            train[4] = new Train("Orsha", 545, DateTime.Now);
            train[5] = new Train("Gomel", 345, DateTime.Now);
            train[6] = new Train("Grodno", 567, DateTime.Now);
            train[7] = new Train("Novopolock", 12, DateTime.Now);
            train.OrderBy(s => s.NumberTrain);

            Console.WriteLine("Введите номер поезда");
            int.TryParse(Console.ReadLine(), out int numTrain); 
            int key = 0;
            for (int i = 0; i < train.Length; i++)
            {

                if (train[i].NumberTrain == numTrain)
                {
                    key = 1;
                    Console.WriteLine("Поезд номер {0} дата {1} в {2}", train[i].NumberTrain, train[i].Time, train[i].Place);
                    break;
                }
            }
            if (key == 0)
            {
                Console.WriteLine("Такого поезда не существует");
            }
            Console.ReadLine();
        }
    }
}
