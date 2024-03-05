namespace Design
{
    internal class CivilianVehicleHandler : AbstractHandler
    {
        public override void Handle(string incoming)
        {
            if (incoming.Contains("Civilian")) 
            {
                return;
            }
            _nextHandler.Handle(incoming);
        }
    }
}
