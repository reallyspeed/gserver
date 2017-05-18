
using System;

public class point
{
	public Int16 x;
	public Int16 y;
	public point(Int16 x, Int16 y)
	{
		this.x = x;
		this.y = y;
	}
	public point()
	{
		this.x = 0;
		this.y = 0;
	}
	public void set (Int16 x, Int16 y)
	{
		this.x = x;
		this.y = y;	
	}
	public void set (byte[] bytes)
	{
		this.x = BitConverter.ToInt16(bytes, 0);
		this.y = BitConverter.ToInt16(bytes, 2);			
	}
	public byte[] bytes()
	{
		byte[] r = new byte[4];
		BitConverter.GetBytes(this.x).CopyTo(r, 0);
		BitConverter.GetBytes(this.y).CopyTo(r, 2);
		return r;
	}
	public String toString()
	{
		return "(" + this.x + ", " + this.y + ")";
	}
}
