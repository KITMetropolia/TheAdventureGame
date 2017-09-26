using System;

public class Weapon
{
	private string name = "weapon";
	private string image = "weapon";
	private double mass = 1.0;
	private int efficiency = 1;
	private int range = 1;

	public Weapon (int weapon)
	{
		switch (weapon)
		{
		case 1:
			name = "Knife";
			image = "knife";
			mass = 1.0;
			efficiency = 1;
			range = 1;
			break;
		case 2:
			name = "Rifle";
			image = "rifle";
			mass = 4.0;
			efficiency = 10;
			range = 10;
			break;
		case 3:
			name = "Shotgun";
			image = "shotgun";
			mass = 6.0;
			efficiency = 15;
			range = 5;
			break;
		}
	}

	public string GetName() {
		return this.name;
	}

	public string GetImage() {
		return this.image;
	}

	public double GetMass() {
		return this.mass;
	}

	public int GetEfficiency() {
		return this.efficiency;
	}

	public int GetRange() {
		return this.range;
	}
}