namespace AbstractFactory
{
    internal class ContemporaryFactory : IFactory
    {
        public IChair CreateChair()
        {
            return new ContemporaryChair();
        }

        public ITable CreateTable()
        {
            return new ContemporaryTable();
        }
    }
}
