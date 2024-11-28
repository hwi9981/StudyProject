using UnityEngine;

namespace FactoryMethod
{
    public class RandomAnimalFactory : IAnimalFactory
    {
        public IAnimal CreateAnimal()
        {
            var type = Random.Range(0, 3);
            switch (type)
            {
                case 0:
                    return new Dog();
                case 1:
                    return new Cat();
                default:
                    return new Duck();
            }
        }
    }
}