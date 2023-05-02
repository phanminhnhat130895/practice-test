using Garage.Models;

namespace Garage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create garage

            string garageName = string.Empty;

            while (string.IsNullOrEmpty(garageName))
            {
                Console.Write("Please input garage name: ");
                garageName = Console.ReadLine();
            }

            Models.Garage garage = new Models.Garage();
            garage.Name = garageName;

            Console.Write("Please input number of level: ");
            int level = 1;
            while(!int.TryParse(Console.ReadLine(), out level) || level < 1)
            {
                Console.Write("Please input valid number of level: ");
            }

            for(int i = 0; i < level; i++)
            {
                int carParkingLots = 0;
                int motobikeParkingLots = 0;
                int currentLevel = i + 1;

                Console.Write($"Please input number of car parking lots of level {currentLevel}: ");
                while(!int.TryParse(Console.ReadLine(), out carParkingLots) || carParkingLots < 0)
                {
                    Console.Write($"Please input valid number of car parking lots of level {currentLevel}: ");
                }

                Console.Write($"Please input number of motobike parking lots of level {currentLevel}: ");
                while(!int.TryParse(Console.ReadLine(), out motobikeParkingLots) || motobikeParkingLots < 0)
                {
                    Console.Write($"Please input valid number of motobike parking lots of level {currentLevel}: ");
                }

                garage.Levels.Add(new Models.GarageLevel()
                {
                    Id = currentLevel,
                    Level = currentLevel,
                    CarParkingLots = carParkingLots,
                    MotobikeParkingLots = motobikeParkingLots
                });
            }

            // car parking
            Car car = new Car();
            car.Id = 1;
            car.LicencePlate = "ABC123";
            bool canPark = true;

            // should read data from DB then check existing
            if(garage.Cars.FirstOrDefault(x => x.LicencePlate == car.LicencePlate) != null)
            {
                Console.WriteLine("This car is already parked in this garage or another one");
                canPark = false;
            }

            if(garage.Levels.All(x => x.CarParkingLots == 0))
            {
                Console.WriteLine("This garage no longer has car parking lots");
                canPark = false;
            }

            if(canPark)
            {
                garage.Cars.Add(car);
                var selectedLevel = garage.Levels.FirstOrDefault(x => x.CarParkingLots > 0);
                if(selectedLevel != null)
                {
                    selectedLevel.CarParkingLots -= 1;
                    Console.WriteLine($"The car with the licence plate \"{car.LicencePlate}\" has been parked on level {selectedLevel.Level}.");
                }
            }

            // motobike parking
            Motobike motobike = new Motobike();
            motobike.Id = 1;
            motobike.LicencePlate = "XYZ123";
            canPark = true;

            // should read data from DB then check existing
            if (garage.Motobikes.FirstOrDefault(x => x.LicencePlate == car.LicencePlate) != null)
            {
                Console.WriteLine("This motobike is already parked in this garage or another one");
                canPark = false;
            }

            if (garage.Levels.All(x => x.MotobikeParkingLots == 0))
            {
                Console.WriteLine("This garage no longer has car parking lots");
                canPark = false;
            }

            if (canPark)
            {
                garage.Motobikes.Add(motobike);
                var selectedLevel = garage.Levels.FirstOrDefault(x => x.MotobikeParkingLots > 0);
                if (selectedLevel != null)
                {
                    selectedLevel.MotobikeParkingLots -= 1;
                    Console.WriteLine($"The motobike with the licence plate \"{motobike.LicencePlate}\" has been parked on level {selectedLevel.Level}.");
                }
            }
        }
    }
}