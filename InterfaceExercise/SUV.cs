using System;
namespace InterfaceExercise
{
    public class SUV : ICompany, IVehicle
    {
        public SUV()
        {
        }

        public bool HasThirdRow { get; set; }
        public int CargoSpaceInSqFt { get; set; }
        public string CompanySlogan { get; set; }
        public string EstDate { get; set; }
        public bool HasFourWheels { get; set; }
        public bool WorkingTransmission { get; set; }
        public bool Under100000Miles { get; set; }
        public bool FourWheelDrive { get; set; }
    }
}
