namespace AbstractFactory
{
    public class Dog : IDog
    {
        public string Name { get; set; }
        public Dog(string name)
        {
            Name = name;
        }
    }
}