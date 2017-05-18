using System;
using System.Net.Sockets;

public class Listener
{
	private TcpListener listener;

	public Listener(Int16 port)
	{
		listener = new TcpListener(port);
		this.id = next_id;
		next_id ++;
		this.name = name;
		this.position = new point();
	}
	
	public void Start(Int16 port)
	{
		
	}
	public void SetPosition(Int16 x, Int16 y)
	{
		this.position.set(x, y);
	}
	public void Move(Int16 x, Int16 y)
	{
		this.position.x += x;
		this.position.y += y;
	}
	public String toString()
	{
		return "Player (" + this.id + ")\n  " + this.name + "\n  " + this.position.toString();
	}
}