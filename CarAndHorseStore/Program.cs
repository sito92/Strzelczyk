using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarAndHorseStore.Models;

namespace CarAndHorseStore
{
    class Program
    {
        static void Main(string[] args)
        {
            var wieslaw = new Horse() {Name = "wieslaw"};

            using (var context = new HorseContext())
            {
                context.Horses.Add(wieslaw);
                context.SaveChanges();
            }

            Console.WriteLine(wieslaw.Name);
            Console.ReadKey();
        }
    }
}
