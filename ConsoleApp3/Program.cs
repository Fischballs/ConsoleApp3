class Program
{
    static void Main(string[] args)
    {
        Time t1 = 125; // 01:30 implicit
        Time t2 = new Time(0, 45); // 00:45
        Time t3 = new Time(1, 15);

        


        Time sum = t1 + t2;
        Time diff = t1 - t2;

        Time reverseDiff = t2 - t1;

        Console.WriteLine("t1: " + t1);      
        Console.WriteLine("t2: " + t2);
        Console.WriteLine("t3: " + t3 + Environment.NewLine); 

        Console.WriteLine("t1 + t2 = " + sum);     
        Console.WriteLine("t1 - t2 = " + diff);    
        Console.WriteLine("t2 - t1 = " + reverseDiff + Environment.NewLine);

        

            Console.WriteLine("t1: " + t1); 
            int totalMinutes = (int)t1;
            Console.WriteLine("Total minutes since midnight: " + totalMinutes + "\n");

         
            Console.WriteLine("t2: " + t2);
            int totalMinutes2 = (int)t2;
            Console.WriteLine("Minutes since midnight: " + totalMinutes2);

            Console.WriteLine("t3: "+ t3);
        int totalminutes3 = (int)t3;
            Console.WriteLine("minutes since midnight: "+ totalminutes3);


            Console.WriteLine("\n t1 + t2 = " + sum);
    }
}
