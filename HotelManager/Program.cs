namespace HotelManager;

class Program
{
    static void Main(string[] args)
    {
        Hotel hotel = new Hotel();
        
        SingleRoom SingleRoom = new SingleRoom(101, 15000);
        DoubleRoom DoubleRoom1 = new DoubleRoom(201, 22000, false);
        DoubleRoom DoubleRoom2 = new DoubleRoom(202, 22000, true);
        Suite Suite = new Suite(301, 20000, 3);

        hotel.AddRoom(SingleRoom);
        hotel.AddRoom(DoubleRoom1);
        hotel.AddRoom(DoubleRoom2);
        hotel.AddRoom(Suite);

        hotel.AddForCleaning(DoubleRoom1);
        hotel.AddForCleaning(DoubleRoom2);
        hotel.AddForCleaning(Suite);

        Console.WriteLine(SingleRoom.Describe());
        Console.WriteLine(DoubleRoom1.Describe());
        Console.WriteLine(DoubleRoom2.Describe());
        Console.WriteLine(Suite.Describe());

        Console.WriteLine("---------------------Check in---------------------");
        Console.WriteLine("--------------------------------------------------");

        Console.WriteLine(hotel.CheckIn(101) ? "Sikeres foglalás" : "Sikertelen foglalás");
        Console.WriteLine(hotel.CheckIn(301) ? "Sikeres foglalás" : "Sikertelen foglalás");

        Console.WriteLine(SingleRoom.Describe());
        Console.WriteLine(DoubleRoom1.Describe());
        Console.WriteLine(DoubleRoom2.Describe());
        Console.WriteLine(Suite.Describe());

        Console.WriteLine("---------------------Check in ujra ---------------------");
        Console.WriteLine("--------------------------------------------------------");

        Console.WriteLine(hotel.CheckIn(101) ? "Sikeres foglalás" : "Sikertelen foglalás");
        Console.WriteLine(hotel.CheckIn(999) ? "Sikeres foglalás" : "Sikertelen foglalás");
        


        Console.WriteLine(SingleRoom.Describe());
        Console.WriteLine(DoubleRoom1.Describe());
        Console.WriteLine(DoubleRoom2.Describe());
        Console.WriteLine(Suite.Describe());

        Console.WriteLine("--------------------------------------------------------");

        Console.WriteLine("Bevétel: " + hotel.TotalIncomePerNight());
        Console.WriteLine("Teljes takaritasi ido: " + hotel.TotalCleaningMinutes() + " perc");
    }
}
