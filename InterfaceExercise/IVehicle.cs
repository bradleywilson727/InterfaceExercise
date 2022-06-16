using System;
namespace InterfaceExercise
{
    public interface IVehicle
    {
        public bool HasFourWheels { get; set; }
        public bool WorkingTransmission { get; set; }
        public bool Under100000Miles { get; set; }
        public bool FourWheelDrive { get; set; }
    }

}
