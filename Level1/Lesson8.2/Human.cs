namespace Lesson8._2
{
    public class Human
    {
        public Human(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name;
        public int Age;

        public const double Pi = 3.14;

        public string SayHello()
        {
            return "Hello";
        }

        public string ProvideInformation()
        {
            return $"My name is {Name}, age={Age}";
        }
    }
}
