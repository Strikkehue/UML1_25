using System;
using System.Collections.Generic;
using System.Text;

namespace UML1_25
{
    public class Pizza
    {
        private double _price;
        private string _topping;
        private string _name;
        private int _no;
        

        public Pizza(int no, string name, string topping, double price)
        {
            _no = no;
            _name = name;           
            _topping = topping;
            _price = price;
        }

        public int No 
        {
            get { return _no; }
            set { _no = value; }
        }
        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public string Topping
        {
            get { return _topping; }
            set { _topping = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public override string ToString()
        {
            return $"{_no} {_name} {_topping} {_price} kr";
        }
    }
}
