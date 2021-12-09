namespace AbstractFactory
{
    public class DogFactory : IFactory
    {
        public IDog CreateAnimal()
        {
            return new Dog("Maskot");
        }
    }
}