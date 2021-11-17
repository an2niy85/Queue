using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            int queue;
            int receptionTime = 10;
            int waitingHours;
            int waitingMinutes;

            Console.WriteLine("Сколько пациентов в очереди?");
            queue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Время приема одного пациента: " + receptionTime + " минут.");
            waitingHours = (queue * receptionTime) / 60;
            waitingMinutes = (queue * receptionTime) % 60;

            Console.WriteLine("Вы должны отстоять в очереди " + waitingHours + " часов и " + waitingMinutes + " минут.");
            Console.ReadLine();
        }
    }
}
