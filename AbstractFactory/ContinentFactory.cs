
using System;

namespace AbstractFactory
{
    /// <summary>
    /// The 'AbstractFactory' abstract class
    /// </summary>
    public abstract class ContinentFactory

    {
        public abstract Herbivore CreateHerbivore();
        public abstract Carnivore CreateCarnivore();

        /// <summary>
        /// The 'AbstractProductA' abstract class
        /// </summary>
        public abstract class Herbivore{}

        /// <summary>
        /// The 'AbstractProductB' abstract class
        /// </summary>
        public abstract class Carnivore
        {
            public abstract void Eat(Herbivore h);
        }

        /// <summary>
        /// The 'ProductA1' class
        /// </summary>
        public class Wildebeest : Herbivore{}

        /// <summary>
        /// The 'ProductB1' class
        /// </summary>
        public class Lion : Carnivore
        {
            public override void Eat(Herbivore h)
            {
                // Eat Wildebeest

                Console.WriteLine(this.GetType().Name +
                                  " eats " + h.GetType().Name);
            }
        }

        /// <summary>
        /// The 'ProductA2' class
        /// </summary>
        public class Bison : Herbivore{}

        /// <summary>
        /// The 'ProductB2' class
        /// </summary>
        public class Wolf : Carnivore
        {
            public override void Eat(Herbivore h)
            {
                // Eat Bison

                Console.WriteLine(this.GetType().Name +
                                  " eats " + h.GetType().Name);
            }
        }

        /// <summary>
        /// The 'Client' class 
        /// </summary>
        public class AnimalWorld
        {
            private Herbivore _herbivore;
            private Carnivore _carnivore;

            // Constructor
            public AnimalWorld(ContinentFactory factory)
            {
                _carnivore = factory.CreateCarnivore();
                _herbivore = factory.CreateHerbivore();
            }

            public void RunFoodChain()
            {
                _carnivore.Eat(_herbivore);
            }
        }
    }
}
