using System;

namespace conditionalStatement
{
    class Program
    {

        static void Main(string[] args)
        {

            

            Console.ReadKey();

        }
        private static int Question1(string answer)
        {
            int score = 0;

            switch (answer.ToUpper())
            {
                case "INDIA":
                    score++;
                    Console.WriteLine("Correct");
                    break;
                case "MALYSIA":
                    Console.WriteLine("'Malasia' do have wild tigers but  but 'india' has more");
                    break;
                default:
                    Console.WriteLine("Incorrect answer");
                    break;
            }

            return score;
        }
        /*static void OneDimensionalArray()
        {
            int[] grades = new int[] { 57, 60, 68,72 }; ;
            int[] notes = new int[4];
            notes[0] = 54;
            notes[1] = 6;
            notes[2] = 65;
            notes[3] = 11;

            for (int count = 0; count < grades.Length; count++)
            {
                Console.WriteLine($"{grades[count]}");
            }
        }
        */
        /*
        static void Loop10DoWhileLoop()
        {
            int x = 0;
            const int maxCount = 10;

            do
            {
                Console.WriteLine($"The value of 'x' is {x}");
                x++;
            }
            while (x < maxCount);
        }

        static void Loop10DoWhileLoopBreakAt4()
        {
            int x = 0;
            const int maxCount = 10;

            Console.WriteLine("Before loop");
            do
            {
                if (x == 4)
                {
                    break;
                }

                Console.WriteLine($"The value of 'x' is {x}");
                x++;
            }
            while (x < maxCount);

            Console.WriteLine("After Loop");

        }

        static void Loop10WhileLoop()
        {
            int x = 0;
            const int maxCount = 10;

            while (x < maxCount)
            {
                Console.WriteLine($"The value of 'x' is {x}");
                x++;
            }

        }

        static void Loop10WhileLoopContinueAt4()
        {
            int x = 0;
            const int maxCount = 10;

            while (x < maxCount)
            {
                if (x == 4)
                {
                    x++;
                    continue;
                }

                Console.WriteLine($"The value of 'x' is {x}");
                x++;
            }

        }

        static void Loop10ForLoop()
        {
            const int maxCount = 10;

            for (int x = 0; x < maxCount; x++)
            {
                Console.WriteLine($"The value of 'x' is {x}");
            }

        }

        static void NestedForLoop()
        {
            const int maxParentLoopCount = 10;
            const int maxChildLoopCount = 5;

            for (int x = 0; x < maxParentLoopCount; x++)
            {
                Console.Write($"{x}: ");
                for (int y = 0; y < maxChildLoopCount; y++)
                {
                    Console.Write($"{y} ");
                }
                Console.WriteLine();
            }

        }
        static void NestedForLoopChildLoopDecrement()
        {
            const int maxParentLoopCount = 10;
            const int maxChildLoopCount = 5;

            for (int x = 0; x < maxParentLoopCount; x++)
            {
                Console.Write($"{x}: ");
                for (int y = maxChildLoopCount - 1; y > -1; y--)
                {
                    Console.Write($"{y} ");
                }
                Console.WriteLine();
            }

        }
        */

        /*
        static void ForEachExample()
        {
            Car[] cars = new Car[] { new Car(200, "Car 1"), new Car(180, "Car 2"), new Car(240, "Car 3"), new Car(300, "Car 4") };

            foreach (iCar car in cars)
            {
                Console.WriteLine($"{car.CarLabel} has a maximum speed of {car.GetMaxSpeed()}");
            }

        }

        

        public interface iCar
        {
            float GetMaxSpeed();
            string CarLabel { get; set; }
        }

        public class Car : iCar
        {
            float _maxSpeed = 0;
            string _carLabel = string.Empty;

            public Car(float maxSpeed, string carLabel)
            {
                _maxSpeed = maxSpeed;
                _carLabel = carLabel;
            }

            public string CarLabel
            {
                get
                {
                    return _carLabel;
                }
                set
                {
                    _carLabel = value;
                }
            }
            public float GetMaxSpeed()
            {
                return _maxSpeed;
            }
        }*/
        /*
         * using System;

        namespace ArrayExamples
        {
        class Program
        {

        static void OneDimensionalArray()
        {
            int[] grades = new int[8];

            grades[0] = 57;
            grades[1] = 60;
            grades[2] = 68;
            grades[3] = 72;
            grades[4] = 65;
            grades[5] = 75;
            grades[6] = 81;
            grades[7] = 84;

            WriteOneDimensionalArrayToScreen(grades);


        }

        static void WriteOneDimensionalArrayToScreen(int[] array)
        {
            for (int count = 0; count <= array.Length - 1; count++)
            {
                Console.WriteLine($"{array[count]}");

            }

        }

        static void TwoDimensionalArray()
        {
            int[,] studentAverageGradesPerYear = new int[4, 3];

            studentAverageGradesPerYear[0, 0] = 54;
            studentAverageGradesPerYear[0, 1] = 70;
            studentAverageGradesPerYear[0, 2] = 80;

            studentAverageGradesPerYear[1, 0] = 51;
            studentAverageGradesPerYear[1, 1] = 67;
            studentAverageGradesPerYear[1, 2] = 86;

            studentAverageGradesPerYear[2, 0] = 64;
            studentAverageGradesPerYear[2, 1] = 62;
            studentAverageGradesPerYear[2, 2] = 76;

            studentAverageGradesPerYear[3, 0] = 62;
            studentAverageGradesPerYear[3, 1] = 68;
            studentAverageGradesPerYear[3, 2] = 82;

            WriteTwoDimensionalArrayToScreen(studentAverageGradesPerYear);


        }

        static void WriteTwoDimensionalArrayToScreen(int[,] array)
        {

            for (int x = 0; x <= array.GetLength(0) - 1; x++)
            {
                for (int y = 0; y <= array.GetLength(1) - 1; y++)
                {

                    Console.Write($"{array[x,y]} \t");

                }
                Console.WriteLine();
            }

        }

        static void ThreeDimensionalArray()
        {
            int[,,] studentAverageGradesPerYearPerCourse = new int[2, 4, 3];

            //course 1
            studentAverageGradesPerYearPerCourse[0, 0, 0] = 55;
            studentAverageGradesPerYearPerCourse[0, 0, 1] = 70;
            studentAverageGradesPerYearPerCourse[0, 0, 2] = 80;

            studentAverageGradesPerYearPerCourse[0, 1, 0] = 62;
            studentAverageGradesPerYearPerCourse[0, 1, 1] = 67;
            studentAverageGradesPerYearPerCourse[0, 1, 2] = 91;

            studentAverageGradesPerYearPerCourse[0, 2, 0] = 64;
            studentAverageGradesPerYearPerCourse[0, 2, 1] = 75;
            studentAverageGradesPerYearPerCourse[0, 2, 2] = 93;

            studentAverageGradesPerYearPerCourse[0, 3, 0] = 61;
            studentAverageGradesPerYearPerCourse[0, 3, 1] = 83;
            studentAverageGradesPerYearPerCourse[0, 3, 2] = 88;

            //course 2
            studentAverageGradesPerYearPerCourse[1, 0, 0] = 52;
            studentAverageGradesPerYearPerCourse[1, 0, 1] = 70;
            studentAverageGradesPerYearPerCourse[1, 0, 2] = 80;

            studentAverageGradesPerYearPerCourse[1, 1, 0] = 67;
            studentAverageGradesPerYearPerCourse[1, 1, 1] = 73;
            studentAverageGradesPerYearPerCourse[1, 1, 2] = 90;

            studentAverageGradesPerYearPerCourse[1, 2, 0] = 64;
            studentAverageGradesPerYearPerCourse[1, 2, 1] = 73;
            studentAverageGradesPerYearPerCourse[1, 2, 2] = 93;

            studentAverageGradesPerYearPerCourse[1, 3, 0] = 55;
            studentAverageGradesPerYearPerCourse[1, 3, 1] = 68;
            studentAverageGradesPerYearPerCourse[1, 3, 2] = 85;

            WriteThreeDimensionalArrayToScreen(studentAverageGradesPerYearPerCourse);
        }

        static void WriteThreeDimensionalArrayToScreen(int[,,] array)
        {
            for (int x =0; x <= array.GetLength(0) -1; x++)
            {
                for (int y = 0; y <= array.GetLength(1) -1; y++)
                {
                    for (int z = 0; z <= array.GetLength(2) - 1 ; z++)
                    {
                        Console.Write($"{array[x,y,z]} \t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine();
            }
        }
        static void JaggedArray()
        {

            int[][] studentAverageGradesPerYear = new int[4][];

            studentAverageGradesPerYear[0] = new int[3] { 50, 70, 54 };
            studentAverageGradesPerYear[1] = new int[2] { 54, 65};
            studentAverageGradesPerYear[2] = new int[2] { 50, 70};
            studentAverageGradesPerYear[3] = new int[1] { 73 };

            WriteJaggedArrayToScreen(studentAverageGradesPerYear);


        }
        static void WriteJaggedArrayToScreen(int[][] array)
        {
            for (int x = 0; x <= array.Length - 1; x++)
            {
                for (int y = 0; y <= array[x].Length - 1; y++)
                {
                    Console.Write($"{array[x][y]} \t");
                }
                Console.WriteLine();
            }

        }


        static void Main(string[] args)
        {
            WriteVehicleDataToScreen();

            Console.ReadKey();
        }

        static void WriteVehicleDataToScreen()
        {
            Vehicle[] vehicles = new Vehicle[5]
            {
                new LondonTaxiCab(),
                new FourByFour(),
                new SpeedBoat(),
                new Cessna(),
                new Helicopter()

            };

            foreach (Vehicle vehicle in vehicles)
            {
                Console.WriteLine($"Name: {vehicle.Name}");
                Console.WriteLine($"Description: {vehicle.GetDescription()}");
                Console.WriteLine($"Number of People can Carry: {vehicle.GetNumPeopleCanCarry()}");
                Console.WriteLine($"Vehicle Type: {vehicle.GetVehicleType()}");

                Console.WriteLine();
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine();

            }


        }


        public class LondonTaxiCab : Vehicle
        {

            const int numPeopleCanCarry = 7;

            public override string Name
            {
                get
                {
                    return "Taxi";
                }
            }

            public override VehicleType GetVehicleType()
            {
                return VehicleType.Land;
            }

            public override string GetDescription()
            {
                return base.GetDescription() + Environment.NewLine + "London Taxi Cab";
            }

            public override int GetNumPeopleCanCarry()
            {
                return numPeopleCanCarry;
            }

        }
        public class FourByFour : Vehicle
        {

            const int numPeopleCanCarry = 4;

            public override string Name
            {
                get
                {
                    return "FourByFour";
                }
            }

            public override VehicleType GetVehicleType()
            {
                return VehicleType.Land;
            }

            public override string GetDescription()
            {
                return base.GetDescription() + Environment.NewLine + "High performance offroad vehicle";
            }

            public override int GetNumPeopleCanCarry()
            {
                return numPeopleCanCarry;
            }

        }

        public class SpeedBoat : Vehicle
        {

            const int numPeopleCanCarry = 6;

            public override string Name
            {
                get
                {
                    return "SpeedBoat";
                }
            }

            public override VehicleType GetVehicleType()
            {
                return VehicleType.Water;
            }

            public override string GetDescription()
            {
                return base.GetDescription() + Environment.NewLine + "Super fast speed boat";
            }

            public override int GetNumPeopleCanCarry()
            {
                return numPeopleCanCarry;
            }

        }
        public class Cessna : Vehicle
        {

            const int numPeopleCanCarry = 2;

            public override string Name
            {
                get
                {
                    return "Cessna";
                }
            }

            public override VehicleType GetVehicleType()
            {
                return VehicleType.Air;
            }

            public override string GetDescription()
            {
                return base.GetDescription() + Environment.NewLine + "Cessna aircraft";
            }

            public override int GetNumPeopleCanCarry()
            {
                return numPeopleCanCarry;
            }

        }
        public class Helicopter : Vehicle
        {

            const int numPeopleCanCarry = 5;

            public override string Name
            {
                get
                {
                    return "Helicopter";
                }
            }

            public override VehicleType GetVehicleType()
            {
                return VehicleType.Air;
            }

            public override string GetDescription()
            {
                return base.GetDescription() + Environment.NewLine + "Helicopter";
            }

            public override int GetNumPeopleCanCarry()
            {
                return numPeopleCanCarry;
            }

        }


        public abstract class Vehicle
        {
            private int _numPeopleCanCarry = 4;
            private string _description = "People carrying vehicle";

            public enum VehicleType
            {
                Land,
                Water,
                Air
            }

            public Vehicle()
            {

            }

            public abstract string Name { get; }

            public abstract VehicleType GetVehicleType();

            public virtual string GetDescription()
            {
                return _description;
            }

            public virtual int GetNumPeopleCanCarry()
            {
                return _numPeopleCanCarry;
            }

        }


        }
        }
        */

    }
}

