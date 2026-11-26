using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager
{
    public abstract class Room
    {
        private int number;
        private int basePrice;
        private bool occupied;

        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        public int BasePrice
        {
            get { return basePrice; }
            set { basePrice = value; }
        }

        public bool Occupied
        {
            get { return occupied; }
            set { occupied = value; }
        }


        public Room(int number, int basePrice)
        {
            this.number = number;
            this.basePrice = basePrice;
            this.occupied = false;
        }


        protected double AddTax(int price)
        {
            return price + price * 4 / 100;
        }

        public abstract int PricePerNight();

        public virtual string Describe()
        {
            return $"{number}. szoba, {PricePerNight()} Ft/éj, {(occupied ? "foglalt" : "szabad")}";
        }
    }
}
