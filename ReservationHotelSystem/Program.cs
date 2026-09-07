namespace ReservationHotelSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> l = new List<string>();
            l.Add("Hello");
            l.Add("World");
            l.Add("!");

            Console.WriteLine(l[0]);
            Console.WriteLine(l[l.Count()-1]);

        }
    }
}
