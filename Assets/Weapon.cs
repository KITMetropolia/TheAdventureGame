using System;
using UnityEngine;
using UnityEngine.UI;

public class Weapon {
	private string wname = "weapon";
	private string image = "weapon";
	private double mass = 1.0;
	private int efficiency = 1;
	private int range = 1;

	public Weapon () {

	}

	public Weapon (int weapon)
	{
		switch (weapon)
		{
		case 1:
			wname = "Knife";
			image = "knife";
			mass = 1.0;
			efficiency = 1;
			range = 1;
			break;
		case 2:
			wname = "Rifle";
			image = "rifle";
			mass = 4.0;
			efficiency = 10;
			range = 10;
			break;
		case 3:
			wname = "Shotgun";
			image = "shotgun";
			mass = 6.0;
			efficiency = 15;
			range = 5;
			break;
		}
	}

	public string GetName() {
		return this.wname;
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