using System;

public class Time
{
    public int minutes { get; set; }
    public int hours { get; set; }
	public Time(int m, int h)
	{
        minutes = m;
        hours = h;
	}
    public Time()
    {
        minutes = 0;
        hours = 0;
    }
    public string getTime()
    {
        return (hours + ":" + minutes);
    }
    public void setTime(int s, int m, int h)
    {
        minutes = m;
        hours = h;
    }
}
