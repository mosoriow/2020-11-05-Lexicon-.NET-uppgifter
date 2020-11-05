using System;

namespace Animals
{ 
    class Animal
    {
        public string name { get; set; }
        public string favouriteFood { get; set; }

        protected Animal(string name, string favouriteFood)
        {
            this.name = name;
            this.favouriteFood = favouriteFood;
        }

        public virtual string ExplainSelf()
        {
            return $"I am {this.name} and my favourite food is {this.favouriteFood}";
        }
    }

    class Cat : Animal
    {
        public Cat(string name, string favouriteFood) : base(name, favouriteFood) { }

         public override string ExplainSelf()
        {
            return $"{base.ExplainSelf()}\nMEEOW";
        }
    }
    class Dog : Animal
    {
        public Dog(string name, string favouriteFood) : base(name, favouriteFood) { }
        public override string ExplainSelf()
        {
            return $"{base.ExplainSelf()}\nVOOF";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Cat("Peter", "Whiskas");
            Animal dog = new Dog("Gunnar", "Meat");

            Console.WriteLine(cat.ExplainSelf());
            Console.WriteLine(dog.ExplainSelf());

            Console.ReadKey();
        }
    }
}
