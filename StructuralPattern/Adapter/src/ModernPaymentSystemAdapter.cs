namespace Adapter
{
    internal class ModernPaymentSystemAdapter
    {
        private readonly ModernPaymentSystem _modernPaymentSystem;
        public ModernPaymentSystemAdapter(ModernPaymentSystem modernPaymentSystem)
        {
            _modernPaymentSystem = modernPaymentSystem;
        }
        public void Payment(string name)
        {
            _modernPaymentSystem.Payment(name);
        }
    }
}
