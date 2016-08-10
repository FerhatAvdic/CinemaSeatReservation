using System;

public class Date
{
    int day;
    string month;
    int year;
	public Date(int d, string m, int y)
	{
        day = d;
        month = m;
        year = y;
	}
        public void getDate()
    {
            if (day==1) Console.WriteLine("0" + day + "st " + month + " " + year);
            else if (day==2) Console.WriteLine("0" + day + "nd " + month + " " + year);
            else if (day==3) Console.WriteLine("0" + day + "rd " + month + " " + year);
            else if (day<10) Console.WriteLine("0" + day + "th " + month + " " + year);
            else Console.WriteLine(day + "th " + month + " " + year);
    }
        public void setDate(int d, string m, int y)
    {
        day = d;
        month = m;
        year = y;
    }
}

