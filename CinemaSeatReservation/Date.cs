using System;

public class Date
{
    public int day { get; set; }
    public string month { get; set; }
    public int year { get; set; }
	public Date(int d, string m, int y)
	{
        day = d;
        month = m;
        year = y;
	}
    public Date()
    {
        day = 0;
        month = "";
        year = 0;
    }
        public string getDate()
    {
            if (day==1) return ("0" + day + "st " + month + " " + year);
            else if (day==2) return ("0" + day + "nd " + month + " " + year);
            else if (day==3) return ("0" + day + "rd " + month + " " + year);
            else if (day<10) return ("0" + day + "th " + month + " " + year);
            else return (day + "th " + month + " " + year);
    }
        public void setDate(int d, string m, int y)
    {
        day = d;
        month = m;
        year = y;
    }
}

