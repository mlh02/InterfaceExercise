using System;
namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public SUV()
        {
        }
        public bool _hasTrunk { get; set; }
        public int Windows { get; set; }
        public string Logo { get; set; }
        public string Solgan { get; set; }
    }
}
