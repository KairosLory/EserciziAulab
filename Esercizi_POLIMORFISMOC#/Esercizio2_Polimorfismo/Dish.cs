using System;
using System.Runtime.CompilerServices;

public class Dish : IMenuItem
{
	public string Name { get; set; }
	public double Price { get; set; }
	public List<string> Ingredients { get; set; }
    public Dish()
	{
	}

  
}
