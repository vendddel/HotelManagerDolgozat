using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager
{
    public  class SingleRoom : Room
    {
        public SingleRoom(int number, int basePrice) : base(number, basePrice)
        {
        }

        public override int PricePerNight()
        {
            return (int)AddTax(BasePrice);
        }
    }
}
