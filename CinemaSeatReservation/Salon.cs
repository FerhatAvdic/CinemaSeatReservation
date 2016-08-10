using System;

public class Salon
{

    public bool[] seats { get; set; } // true if reserved, otherwise false
    public int reservedSeats { get; set; }
	public Salon()
	{
        seats = new bool[100];
        reservedSeats = 0;
	}

   public bool isReserved(int seatNumber)
    {
        return seats[seatNumber - 1];
    }
    public void reserveSeat(int seatNumber)
    {
        seats[seatNumber - 1] = true;
        reservedSeats++;
    }
    public void cancelReservation(int seatNumber)
    {
        seats[seatNumber - 1] = false;
        reservedSeats--;
    }
    public int freeSeats()
    {
        return seats.Length - reservedSeats;
    }
}
