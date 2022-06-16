using System;
namespace InterfaceExercise
{
    public class Car : ICompany, IVehicle
    {
        public Car()
        {
        }

        public int TrunkSizeInSqFt { get; set; }
        public int FourDoorOrTwoDoor { get; set; }
        public string CompanySlogan { get; set; }
        public string EstDate { get; set; }
        public bool HasFourWheels { get; set; }
        public bool WorkingTransmission { get; set; }
        public bool Under100000Miles { get; set; }
        public bool FourWheelDrive { get; set; }
    }
}
