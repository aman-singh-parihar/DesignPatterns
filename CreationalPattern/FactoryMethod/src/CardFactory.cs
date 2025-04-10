namespace FactoryMethod
{
    abstract class CardFactory
    {
        protected abstract Card CreateCard();
        public Card Card { get => this.CreateCard(); }
    }
}
