namespace Design
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new ArgumentException();
            }
            catch (ArgumentException ex) 
            {
                Console.WriteLine("Arguemtn Excpeiont");
                throw new Exception();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Excpeiont");

            }

            Console.WriteLine("Hello");

            IHandler Civilian = new CivilianVehicleHandler();
            IHandler Fire = new FireVehicleHandler();

            Civilian.SetNextHandler(Fire);
            Civilian.Handle("Fire");
        }
    }
}
