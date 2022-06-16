using System;
namespace InterfaceExercise
{
    public class Truck : ICompany, IVehicle
    {
        public Truck()
        {
        }

        public int BedSizeInSqFt { get; set; }
        public bool ExtendedCab { get; set; }
        public string CompanySlogan { get; set; }
        public string EstDate { get; set; }
        public bool HasFourWheels { get; set; }
        public bool WorkingTransmission { get; set; }
        public bool Under100000Miles { get; set; }
        public bool FourWheelDrive { get; set; }
    }

}
