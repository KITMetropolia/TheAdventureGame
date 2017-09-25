using System;

public class Weapon
{
	private string name = "weapon";
	private double mass = 1.0;
	private int efficiency = 1;

	public Weapon (int weapon)
	{
		switch (weapon)
		{
		case 1:
			name = "Knife";
			mass = 1.0;
			efficiency = 1;
			break;
		case 2:
			name = "Rifle";
			mass = 4.0;
			efficiency = 10;
			break;
		case 3:
			name = "Shotgun";
			mass = 6.0;
			efficiency = 15;
			break;
		}
	}

	public string GetName() {
		return this.name;
	}

	public double GetMass() {
		return this.mass;
	}

	public int GetEfficiency() {
		return this.efficiency;
	}

	public void UseWeapon() {

	}
}