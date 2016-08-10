using System;

public class Projection
{
    public Time time { get; set; }
    public Date date { get; set; }
    public Salon salon { get; set; }
	public Projection(Time t, Date d)
	{
        time=t;
        date=d;
        salon = new Salon();
	}
    public Projection()
    {
        time = new Time();
        date = new Date();
        salon = new Salon();
    }
}
