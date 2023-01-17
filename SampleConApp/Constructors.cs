using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    class Infortainment
    {
        public string Name { get; set; }
        public bool HasMaps { get; set; }
        public bool HasUSB { get; set; }
        public bool HasAuxillary { get; set; }
        public bool HasCD { get; set; }
        public string CurrentPlayer { get; set; } = "CD Player";
    }

    class Car
    {
        public string ChasisNo { get; set; }
        public string BodyType { get; set; }
        public string FuelType { get; set; }
        public int NoOfSeats { get; set; }

        public Car(Infortainment infotainment)
        {
            this.Infotainment = infotainment;
        }
        public void ReplaceInfotainment(Infortainment infotainment)
        {
            this.Infotainment = infotainment;
        }
        public Infortainment Infotainment { get; private set; }

        public void Run()
        {
            Console.WriteLine("Car has started");
            Console.WriteLine("Player of the type {0} has started in {1}", Infotainment.CurrentPlayer, Infotainment.Name);
        }

    }
    class Constructors
    {
        static void Main(string[] args)
        {
            Car c = new Car(new Infortainment { Name = "UBl", HasMaps = false });
           c.Run();
        }
    }
}
