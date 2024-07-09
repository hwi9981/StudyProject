using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Strategy
{
    public class Demo : MonoBehaviour
    {
        void Start()
        {
            Debug.Log("Start");
            for (int i = 0; i < 5; i++)
            {
                var index = Random.Range(0, 2);
                var ticket = new Ticket();
                ticket.SetName("Ticket " + i);
                ticket.SetPrice(100);
                switch (index)
                {
                    case 0:
                        ticket.SetPromoteStrategy(new HalfDiscountStrategy());
                        break;
                    case 1:
                        ticket.SetPromoteStrategy(new QuarterDiscountStrategy());
                        break;
                    default:
                        ticket.SetPromoteStrategy(new NoDiscountStrategy());
                        break;
                }
                Debug.Log($"Promoted price of {ticket.GetName()} is {ticket.GetPromotedPrice()}");
            }
            
            
        }
    }

}
