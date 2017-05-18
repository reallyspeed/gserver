
using System;

public class GServer
{
	static void Main(string[] args)
    {
		User u1 = new User("toast");
        DrawPane dp = new DrawPane();
		
		Console.WriteLine("User:\n" + u1.toString());
    }
}
