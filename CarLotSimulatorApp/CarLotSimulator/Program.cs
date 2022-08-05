namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property

            var LotA = new CarLot();
            var LotB = new CarLot();


            var car1 = new Car(2012, "SUBARU", "FORESTER", "Brrrrr", "Beep", true);
            LotA.Cars.Add(car1);
            car1.MakeHonkNoise(car1.EngineNoise);
            car1.MakeHonkNoise(car1.HonkNoise);
            var car2 = new Car();
            car2.Make = "FORD";
            car2.Year = 2014;
            car2.Model = "F-450";
            car2.IsDriveable = false;
            car2.EngineNoise = "...";
            car2.HonkNoise = "Hooonk";
            LotB.Cars.Add(car2);
            car2.MakeHonkNoise(car2.EngineNoise);
            car2.MakeHonkNoise(car2.HonkNoise);
            var car3 = new Car()
            {
                Make = "HONDA",
                Year = 2014,
                Model = "CBR1000RR",
                IsDriveable = true,
                EngineNoise = "NUUM",
                HonkNoise = "Baullga"
            };
            LotA.Cars.Add(car3);
            car3.MakeHonkNoise(car3.EngineNoise);
            car3.MakeHonkNoise(car3.HonkNoise);
            var car4 = new Car();
            {
                car4.Make = "MAZDA";
                car4.Year = 2006;
                car4.Model = "B3000";
                car4.IsDriveable = true;
                car4.EngineNoise = "Zzooom";
                car4.HonkNoise = "Moo";
            }
            LotA.Cars.Add(car4);
            car4.MakeHonkNoise(car4.EngineNoise);
            car4.MakeHonkNoise(car4.HonkNoise);
            var car5 = new Car();
            {
                car5.Make = "SATURN";
                car5.Year = 2007;
                car5.Model = "VUE";
                car5.IsDriveable = false;
                car5.EngineNoise = "...";
                car5.HonkNoise = "Silence";
            }
            LotB.Cars.Add(car5);
            car5.MakeHonkNoise(car5.EngineNoise);
            car5.MakeHonkNoise(car5.HonkNoise);
            var car6 = new Car();
            {
                car6.Make = "FORD";
                car6.Year = 2003;
                car6.Model = "FOCUS";
                car6.IsDriveable = true;
                car6.EngineNoise = "Vroom";
                car6.HonkNoise = "Ugh";
            }
            LotA.Cars.Add(car6);
            car6.MakeHonkNoise(car6.EngineNoise);
            car6.MakeHonkNoise(car6.HonkNoise);
            var car7 = new Car();
            {
                car7.Make = "VOLVO";
                car7.Year = 2009;
                car7.Model = "XC90";
                car7.IsDriveable = true;
                car7.EngineNoise = "Vroom";
                car7.HonkNoise = "Beep Beep";
            }
            LotA.Cars.Add(car7);
            car7.MakeHonkNoise(car7.EngineNoise);
            car7.MakeHonkNoise(car7.HonkNoise);
            var car8 = new Car();
            {
                car8.Make = "MERCEDES-BENZ";
                car8.Year = 2013;
                car8.Model = "C180";
                car8.IsDriveable = true;
                car8.EngineNoise = "Cho Cho";
                car8.HonkNoise = "HOOOOG";
            }
            LotA.Cars.Add(car8);
            car8.MakeHonkNoise(car8.EngineNoise);
            car8.MakeHonkNoise(car8.HonkNoise);
            var car9 = new Car();
            {
                car9.Make = "NISSAN";
                car9.Year = 2015;
                car9.Model = "370Z";
                car9.IsDriveable = true;
                car9.EngineNoise = "ZIPZIP";
                car9.HonkNoise = "MEEP MEEP";
            }
            LotA.Cars.Add(car9);
            car9.MakeHonkNoise(car9.EngineNoise);
            car9.MakeHonkNoise(car9.HonkNoise);
            var carX = new Car();
            {
                carX.Make = "CHEVROLET";
                carX.Year = 2001;
                carX.Model = "SILVERADO 3500";
                carX.IsDriveable = true;
                carX.EngineNoise = "Chuga Chuga";
                carX.HonkNoise = "BOOOOOOGGGA";
            }
            LotA.Cars.Add(carX);
            carX.MakeHonkNoise(carX.EngineNoise);
            carX.MakeHonkNoise(carX.HonkNoise);
            System.Console.WriteLine("These are are working cars");
            foreach (var car in LotA.Cars)
            {
                System.Console.WriteLine($" {car.Make} {car.Model} {car.Year}");
                
            }
            System.Console.WriteLine("These cars are not working");
            foreach (var car in LotB.Cars)
            {
                System.Console.WriteLine($" {car.Make} {car.Model} {car.Year}");
            }


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
