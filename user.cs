using System;

public class User
{
	private static byte next_id = 1;
	public byte id;
	public String name;
	public point position;

	public User(String name)
	{
		this.id = next_id;
		next_id ++;
		this.name = name;
		this.position = new point();
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