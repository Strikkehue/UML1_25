using System;
using System.Collections.Generic;
using System.Text;

namespace UML1_25
{
    public class Customer
    {
        private string _name;
        private string _number;
        private string _adress;
        private int _no;

        public Customer(int no, string name, string adress, string number)
        {
            _no = no;
            _name = name;
            _number = number;
            _adress = adress;
            
        }

        public int No
        {
            get { return _no; }
            set { _no = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Number
        {
            get { return _number; }
            set { _number = value; }
        }

        public string Adress
        {
            get { return _adress; }
            set { _adress = value; }
        }

        public override string ToString()
        {
            return $"{_no} {_name} {_adress} {_number}";
        }
    }
}
