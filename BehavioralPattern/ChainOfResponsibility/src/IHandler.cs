namespace Design
{
    internal interface IHandler
    {
        void SetNextHandler(IHandler nextHandler);
        void Handle(string incoming);
    }
}
