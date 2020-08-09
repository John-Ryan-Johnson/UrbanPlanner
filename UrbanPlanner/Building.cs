using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace UrbanPlanner
{
    class Building
    {
        //properties
        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Volume { get; private set; }

        //fields
        private string _designer = "John Johnson";
        private DateTime _dateConstructed = new DateTime();
        private string _address = "";
        private string _owner = "";

        //constructor
        public Building(string address)
        {
            this._address = address;
        }

        //methods
        public void Construct()
        {
            _dateConstructed = DateTime.Now;
            Volume = 3 * Stories * Depth * Width;
        }

        public void Purchase(string owner)
        {
            _owner = owner;
            Console.WriteLine($"{_address}------\n" +
                $"Designed by {_designer}\n" +
                $"Constructed on {_dateConstructed}\n" +
                $"Owned by {_owner}\n" +
                $"{Volume} cubic meters of space\n"
                );
        }


    }

}
