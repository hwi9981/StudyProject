using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FactoryMethod
{
    public class Demo : MonoBehaviour
    {
        private void Start()
        {
            IAnimalFactory factory;
            int type = Random.Range(0, 2);

            switch (type)
            {
                case 0:
                    Debug.Log("Random Factory");
                    factory = new RandomAnimalFactory();
                    break;
                default:
                    Debug.Log("Basic Factory");
                    factory = new BasicAnimalFactory();
                    break;
            }
            
            Debug.Log(factory.CreateAnimal().GetName());
            Debug.Log(factory.CreateAnimal().GetName());
            Debug.Log(factory.CreateAnimal().GetName());
            Debug.Log(factory.CreateAnimal().GetName());
            Debug.Log(factory.CreateAnimal().GetName());
            Debug.Log(factory.CreateAnimal().GetName());
            Debug.Log(factory.CreateAnimal().GetName());
        }
    }
}