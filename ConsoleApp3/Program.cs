class Program
{
    static void Main(string[] args)
    {
        Time time1 = new Time(10, 5);   // 10:05
        Time time2 = new Time(0, 45);   // 00:45
        Time time3 = new Time(23, 59);  // 23:59

        Console.WriteLine("Time 1 (minutes since midnight): " + time1);
        Console.WriteLine("Time 2 (minutes since midnight): " + time2);
        Console.WriteLine("Time 3 (minutes since midnight): " + time3);
    }
}

