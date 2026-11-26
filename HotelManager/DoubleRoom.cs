using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager
{
    public class DoubleRoom : Room, ICleanable
    {
        private bool hasBalcony;
        public bool HasBalcony
        {
            get { return hasBalcony; }
            set { hasBalcony = value; }
        }

        public DoubleRoom(int number, int basePrice, bool hasBalcony) : base(number, basePrice)
        {
            this.hasBalcony = hasBalcony;
        }

        public override int PricePerNight()
        {
            BasePrice += hasBalcony ? 5000 : 0;
            return (int)AddTax(BasePrice);
        }

        public int CleaningMinutes()
        {
            return hasBalcony ? 40 : 30;
        }
    }
}
