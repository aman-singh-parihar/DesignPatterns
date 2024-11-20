namespace Parking
{
    public enum SpotSize 
    {
        Car = 1,
        TwoWheeler = 1,
        Bus = 5
    }
    public abstract class Vehicle
    {
        public abstract SpotSize RequiredSpots { get; }
        public abstract List<ParkingSpotType> ParkingSpotTypes { get; }
    }
    public class Car : Vehicle
    {
        public override SpotSize RequiredSpots => SpotSize.Car;

        public override List<ParkingSpotType> ParkingSpotTypes => new() { ParkingSpotType.Compact, ParkingSpotType.Large };

    }
    public class TwoWheeler : Vehicle
    {
        public override SpotSize RequiredSpots => SpotSize.TwoWheeler;
        public override List<ParkingSpotType> ParkingSpotTypes => new() { ParkingSpotType.MotorCycle };
    }
    public class Bus : Vehicle
    {
        public override SpotSize RequiredSpots => SpotSize.Bus;
        public override List<ParkingSpotType> ParkingSpotTypes => new() { ParkingSpotType.Large };
    }
    public enum ParkingSpotType
    {
        Compact, Large, MotorCycle
    }

    public class ParkingTicket
    {
        public Vehicle? Vehicle { get; set; }
        public ParkingSpotType? ParkingSpotType { get; set; }
    }

    public class ParkingSpot
    {

        public bool IsAvailable { get; set; }
        public ParkingSpotType? ParkingSpotType { get; set; }
    }
    class ParkingService
    {
        List<ParkingSpot> parkingSpots;


        public List<ParkingSpot> CountWithType { get => parkingSpots.Where(spot => spot.IsAvailable).Select(spot => spot).ToList(); }
        public ParkingService(int compact, int large, int motorCycle)
        {
            parkingSpots = new List<ParkingSpot>();
            for (int i = 0; i < compact; i++) { parkingSpots.Add(new ParkingSpot() {IsAvailable = true, ParkingSpotType = ParkingSpotType.Compact }); }
            for (int i = 0; i < large; i++) { parkingSpots.Add(new ParkingSpot() {IsAvailable = true, ParkingSpotType = ParkingSpotType.Large }); }
            for (int i = 0; i < motorCycle; i++) { parkingSpots.Add(new ParkingSpot() {IsAvailable = true, ParkingSpotType = ParkingSpotType.MotorCycle }); }
        }
        
        public ParkingTicket Park(Vehicle vehicle)
        {
            var requiredSpots = vehicle.RequiredSpots;
            var parkingSpotTypes = vehicle.ParkingSpotTypes;

            ParkingSpot? availableSpot = null;

            var availableSpots = parkingSpots.Where(spot => parkingSpotTypes.Any(x => x == spot.ParkingSpotType) && spot.IsAvailable).ToList();

            if ((int)requiredSpots > availableSpots.Count) 
            {
                Console.WriteLine("No Parking Avaialable");
                return null;
            }

            var parkhere = availableSpots.Take((int)requiredSpots);

            foreach (var spot in parkhere) 
            {
                spot.IsAvailable = false;
            }

            var ticket = new ParkingTicket();
            ticket.ParkingSpotType = availableSpots?.FirstOrDefault()?.ParkingSpotType;
            ticket.Vehicle = vehicle;
            return ticket;
        }
        public void Unpark(Vehicle vehicle, ParkingTicket ticket) 
        {
            var requiredSpots = vehicle.RequiredSpots;
            var parkingSpotType = ticket.ParkingSpotType;
            var bookedSpots = parkingSpots.Where(spot => parkingSpotType == spot.ParkingSpotType && !spot.IsAvailable).ToList();
            for (int i = 0; i < (int)requiredSpots; i++)
            {
                bookedSpots.FirstOrDefault().IsAvailable = true;
            }

        }


    }

    internal class Program
    {
        static void CheckParking(ParkingService parkingService, Vehicle vehicle) 
        {
            var parkingTypes = parkingService.CountWithType;
            var compact = parkingTypes.Where(x => x.ParkingSpotType == ParkingSpotType.Compact).ToList();
            var large = parkingTypes.Where(x => x.ParkingSpotType == ParkingSpotType.Large).ToList();
            var motorcycle = parkingTypes.Where(x => x.ParkingSpotType == ParkingSpotType.MotorCycle).ToList();

            Console.WriteLine($"Vehicle: {vehicle.GetType().Name}, Parking: {compact?.FirstOrDefault()?.ParkingSpotType}, {compact.Count} || Parking: {large?.FirstOrDefault()?.ParkingSpotType}, {large?.Count} || Parking: {motorcycle?.FirstOrDefault()?.ParkingSpotType}, {motorcycle?.Count}");
            Console.WriteLine($"Total parking remaining {parkingTypes.Count}");
           
            
            Console.WriteLine("-------------------");

        }
        static void Main(string[] args)
        {
            var parkingService = new ParkingService(20, 30, 50);
            Console.WriteLine($"----------Total parking {parkingService.CountWithType.Count}----------");
            for (int i = 0; i < 10; i++) 
            {
                var car = new Car();
                parkingService.Park(car);
                CheckParking(parkingService, car);

                var bus = new Bus();
                parkingService.Park(bus);
                CheckParking(parkingService, bus);

                var motorCyle = new TwoWheeler();
                parkingService.Park(motorCyle);
                CheckParking(parkingService, motorCyle);
            }

            
            //parkingService.Unpark(car, ticket);
        }
    }
}
