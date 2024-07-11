namespace FactoryMethod
{
    public class BasicAnimalFactory : IAnimalFactory
    {
        private int m_Index = 0;
        public IAnimal CreateAnimal()
        {
            switch (m_Index)
            {
                case 0:
                    m_Index++;
                    return new Dog();
                    break;
                case 1:
                    m_Index++;
                    return new Cat();
                    break;
                default:
                    m_Index = 0;
                    return new Duck();
                    break;
            }

            return null;
        }
    }
}