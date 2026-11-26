using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager
{
    public class Suite : Room, ICleanable
    {
        private int roomCount;
        public int RoomCount
        {
            get { return roomCount; }
            set { roomCount = value; }
        }
        public Suite(int number, int basePrice, int roomCount) : base(number, basePrice)
        {
            this.roomCount = roomCount;
        }

        public override int PricePerNight()
        {
            BasePrice *= roomCount;
            return (int)AddTax(BasePrice);
        }
        public override string Describe()
        {
            return $"{Number}. szoba, {PricePerNight()} Ft/éj, {(Occupied ? "foglalt" : "szabad")}, {RoomCount} helyiség";
        }

        public int CleaningMinutes()
        {
            return RoomCount * 20;
        }
    }
}
