using System;

public class Time
{
    int seconds;
    int minutes;
    int hours;
	public Time(int s, int m, int h)
	{
        seconds = s;
        minutes = m;
        hours = h;
	}
    public void getTime()
    {
        Console.WriteLine(hours + ":" + minutes + ":" + seconds);
    }
    public void setTime(int s, int m, int h)
    {
        seconds = s;
        minutes = m;
        hours = h;
    }
}
