using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager
{
    public class Hotel
    {
        private List<Room> rooms;
        private List<ICleanable> cleaningList;

        public Hotel()
        {
            rooms = new List<Room>();
            cleaningList = new List<ICleanable>();
        }
        public void AddRoom(Room room)
        {
            rooms.Add(room);
        }
        public void AddForCleaning(ICleanable item)
        {
            cleaningList.Add(item);
        }

        public int TotalIncomePerNight()
        {
            int totalIncome = 0;
            foreach (Room room in rooms)
            {
                if (room.Occupied)
                {
                    totalIncome += room.PricePerNight();
                }
            }
            return totalIncome;
        }

        public int TotalCleaningMinutes()
        {
            int totalMinutes = 0;
            foreach (ICleanable item in cleaningList)
            {
                totalMinutes += item.CleaningMinutes();
            }
            return totalMinutes;
        }

        public bool CheckIn(int number)
        {
            foreach (Room room in rooms)
            {
                if (room.Number == number && !room.Occupied)
                {
                    room.Occupied = true;
                    return true;
                }
            }
            return false;
        }

    }
}
