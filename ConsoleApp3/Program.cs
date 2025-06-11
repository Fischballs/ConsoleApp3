class Program
{
    static void Main(string[] args)
    {
        Time t1 = new Time(1, 30); // 01:30
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
        Console.WriteLine("t2 - t1 = " + reverseDiff); 
    }
}
