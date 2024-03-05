namespace Design
{
    internal class FireVehicleHandler : AbstractHandler
    {
        public override void Handle(string incoming)
        {
            if (incoming.Contains("FireVehicleHandler")) 
            {
                return;
            }
            _nextHandler.Handle(incoming);
        }
    }
}
