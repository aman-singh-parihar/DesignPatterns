namespace Adapter
{
    internal class LegacyPaymentSystem
    {
        internal void Payment(string name)
        {
            Console.WriteLine($"{name}Payment processed using Legacy Payment System");
        }
    }
}
