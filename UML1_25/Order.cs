using System;
using System.Collections.Generic;
using System.Text;

namespace UML1_25
{
    public class Order
    {
        
        private bool _isDelivered = false;
        private static int _counter = 0;
        public Customer Customer { get; }
        public Pizza Pizza { get; }
        public DateTime StartDate { get; private set; }

        public Order(Pizza pizza, Customer customer, bool isDelivered)
        {
            Customer = customer;
            Pizza = pizza;
            
            Id = ++_counter;
            
            _isDelivered = isDelivered;
            StartDate = DateTime.Now;
        }
        
        public bool isDelivered
        {
            get { return _isDelivered; }
            set { _isDelivered = value; }
        }

        public int Id { get; }

        public double CalculateTotalPrice()
        {
            if (isDelivered == true)
            {
                return (Pizza.Price * 1.25) + 40;
            } else
            {
                return Pizza.Price * 1.25;
            }
        }

        public void PrintReciept()
        {
            Console.WriteLine($"Ordrenummer : {Id} er bestilt {StartDate}");
            Console.WriteLine($"af {Customer.ToString()}");
            Console.WriteLine($"og der er bestilt {Pizza.ToString()}.");
            Console.WriteLine($"den totale pris inklusiv moms er {CalculateTotalPrice()}");
            if(_isDelivered == true)
            {
                Console.WriteLine("Ordren leveres");
            }
            else
            {
                Console.WriteLine("Ordren leveres ikke");
            }
        }
    }
}
