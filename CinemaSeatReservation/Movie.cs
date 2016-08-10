using System;

public class Movie
{
    public string name {get; set;}
    public Projection[] projections { get; set; }
	public Movie()
	{
        name = "";
        projections = new Projection[15];
	}
    public string getName()
    {
        return name;
    }
    public void setName(string n)
    {
        name = n;
    }
    public Projection getProjection(int index)
    {
        return projections[index];
    }
}
