using System;

public interface IMenuItem
{
	string Name { get; set; }
	double Price { get; set; }

}
public class Restaurant
{
	private string _name;
	private Dish[] _dishes;
	private Drink[] _drinks;

	public Restaurant()
	{
	}

	public void StampaMenu()
	{
	}
}
