namespace FactoryMethodPattern
{
    public class TigerFactory : IAnimalFactory
    {
        public override IAnimal CreateAnimal()
        {
            // Returns Tiger
            return new Tiger();
        }
    }
}
