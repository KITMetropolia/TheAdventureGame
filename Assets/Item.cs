using System;

public class Item
{
	private string name = "item";
	private string image = "item";
	private double mass = 1.0;
	private double heal = 1.0;
	private double hunger = 1.0;
	private double thirst = 1.0;

	public Item (int item)
	{
		switch (item) {
		case 1:
			name = "Carrot";
			image = "carrot";
			mass = 0.2;
			heal = 0.5;
			hunger = 1.0;
			thirst = 0.0;
			break;
		case 2:
			name = "Water bottle";
			image = "waterbottle";
			mass = 1.0;
			heal = 2.0;
			hunger = 0.0;
			thirst = 5.0;
			break;
		}
	}

	public string GetName () {
		return this.name;
	}

	public string GetImage () {
		return this.image;
	}

	public double GetMass () {
		return this.mass;
	}

	public double GetHeal () {
		return this.heal;
	}

	public double GetHunger () {
		return this.hunger;
	}

	public double GetThirst () {
		return this.thirst;
	}
}


