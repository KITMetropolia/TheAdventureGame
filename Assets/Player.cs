using System;

public class Player
{

	//player's initial stats
	private string name = "Pekka";
	private double strength = 100.0;
	private double health = 100.0;
	private double hunger = 0.0;
	private double thirst = 0.0;
	private Weapon primaryWeapon = new Weapon(1);

	public Player ()
	{
		
	}

	public string GetName() {
		return this.name;
	}

	public void SetName(string newName) {
		name = newName;
	}

	public double GetStrength() {
		return this.strength;
	}

	public void ChangeStrength(double amount) {
		strength += amount;
		if (strength < 0.0) {
			strength = 0.0;
		}
	}

	public double GetHealth() {
		return this.health;
	}

	public void ChangeHealth(double amount) {
		health += amount;
		if (health > 100.0) {
			health = 100.0;
		}
		if (health <= 0.0) {
			health = 0.0;
		}
	}

	public double GetHunger() {
		return this.hunger;
	}

	public void ChangeHunger(double amount) {
		hunger += amount;
		if (hunger > 100.0) {
			hunger = 100.0;
			ChangeHealth (-1.0);
		}
		if (hunger < 0.0) {
			hunger = 0.0;
		}
	}

	public double GetThirst() {
		return this.thirst;
	}

	public void ChangeThirst(double amount) {
		thirst += amount;
		if (thirst > 100.0) {
			thirst = 100.0;
			ChangeHealth (-1.0);
		}
		if (thirst < 0.0) {
			thirst = 0.0;
		}
	}

	public Weapon GetPrimaryWeapon() {
		return this.primaryWeapon;
	}

	public void SetPrimaryWeapon(int set) {
		primaryWeapon = new Weapon (set);
	}

	public void Move(string direction) {
		
	}
}

