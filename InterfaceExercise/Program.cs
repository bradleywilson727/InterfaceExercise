using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany DONE

            //Create 3 classes called Car , Truck , & SUV DONE

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.DONE

        //In ICompany

            /*Create 2 members that are specific to each every company DONE

        //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class DONE
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members. DONE
             * 
             */

            //Now, create objects of your 3 classes and give their members values; DONE
            //Creatively display and organize their values DONE

        var myCar = new Car();
            myCar.TrunkSizeInSqFt = 16;
            myCar.FourDoorOrTwoDoor = 4;
            myCar.CompanySlogan = "You drive while we connive";
            myCar.EstDate = "2005";
            myCar.HasFourWheels = true;
            myCar.WorkingTransmission = true;
            myCar.Under100000Miles = true;
            myCar.FourWheelDrive = false;


         var myTruck = new Truck();
            myTruck.BedSizeInSqFt = 32;
            myTruck.ExtendedCab = false;
            myTruck.CompanySlogan = "You drive while we connive";
            myTruck.EstDate = "2005";
            myTruck.HasFourWheels = true;
            myTruck.WorkingTransmission = true;
            myTruck.Under100000Miles = false;
            myTruck.FourWheelDrive = true;

         var mySuv = new SUV();
            mySuv.HasThirdRow = true;
            mySuv.CargoSpaceInSqFt = 18;
            mySuv.CompanySlogan = "You drive while we connive";
            mySuv.EstDate = "2005";
            mySuv.HasFourWheels = true;
            mySuv.WorkingTransmission = false;
            mySuv.Under100000Miles = false;
            mySuv.FourWheelDrive = true;

            Console.WriteLine("These are the vehicles we have for sale at your local used car dealership.");
            Console.WriteLine("");
            Console.WriteLine("Our new Toyota Camry has the following specifications:");
            Console.WriteLine($"Trunk Size of {myCar.TrunkSizeInSqFt}sqft. \nStandard {myCar.FourDoorOrTwoDoor} door sedan. \nA {myCar.WorkingTransmission} working transmission.");
            Console.WriteLine("");
            Console.WriteLine("---------------------------");
            Console.WriteLine("");
            Console.WriteLine("Our used Ford F150 has the following specifications:");
            Console.WriteLine($"Bed Size of {myTruck.BedSizeInSqFt}sqft. \nA {myTruck.FourWheelDrive} four wheel drive package. \nA {myTruck.WorkingTransmission} working transmission.");
            Console.WriteLine("");
            Console.WriteLine("---------------------------");
            Console.WriteLine("");
            Console.WriteLine("Our used Kia Sportage has the following specifications:");
            Console.WriteLine($"A {mySuv.HasThirdRow} third row option. \nA {mySuv.FourWheelDrive} four wheel drive package. \nA cargo space of {mySuv.CargoSpaceInSqFt}sqft.");

        }
    }
}
