using System;

public class Movie
{
    private string name;
    private Projection[] projections;
	public Movie(string n)
	{
        name = n;
        projections = new Projection[15];
	}
    public string getName()
    {
        return name;
    }
    public Projection getProjection(int index)
    {
        return projections[index];
    }
}
