namespace Adapter
{
    internal class LegacyPaymentSystemAdapter
    {
        private readonly LegacyPaymentSystem _legacyPaymentSystem;
        public LegacyPaymentSystemAdapter(LegacyPaymentSystem legacyPaymentSystem)
        {
            _legacyPaymentSystem = legacyPaymentSystem;
        }
        public void Payment(string name)
        {
            
            _legacyPaymentSystem.Payment(name);
        }
    }
}
