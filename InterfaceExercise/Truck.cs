using System;
namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public Truck()
        {
        }
        public bool _extraWheels { get; set; }
        public string Size { get; set; }
        public string Logo { get; set; }
        public string Solgan { get; set; }
    }
}
