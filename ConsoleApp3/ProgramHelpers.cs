using System;

public struct Time
{
    private readonly int minutes;

    public Time(int hh, int mm)
    {
        this.minutes = 60 * hh + mm;
    }

    public override string ToString()
    {
        return minutes.ToString();
    }
}
