namespace AbstractFactory
{
    public class CatFactory : IFactory
    {
        public ICat CreateAnimal()
        {
            return new Cat("Bobo");
        }
    }
}