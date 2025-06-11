public struct Time
{
    private readonly int minutes;

    public Time(int hh, int mm)
    {
        this.minutes = 60 * hh + mm;
    }

    public int Hour => minutes / 60;

    public int Minute => minutes % 60;

    public override string ToString()
    {
        return string.Format("{0:D2}:{1:D2}", Hour, Minute);
    }

    // Overload + operator
    public static Time operator +(Time t1, Time t2)
    {
        return new Time(0, t1.minutes + t2.minutes);
    }

    // Overload - operator
    public static Time operator -(Time t1, Time t2)
    {
        int diff = t1.minutes - t2.minutes;
        if (diff < 0)
        {
            diff = 0; 
        }
        return new Time(0, diff);
    }
}
