using System;

public class Player
{
	private string name = "Pekka";
	private int strength = 100;
	private int health = 100;
	private int hunger = 0;
	private int thirst = 0;
	private Weapon primaryWeapon;

	public Player ()
	{
		primaryWeapon = new Weapon (1);
	}

	public string GetName() {
		return this.name;
	}

	public int GetStrength() {
		return this.strength;
	}

	public int GetHealth() {
		return this.health;
	}

	public int GetHunger() {
		return this.hunger;
	}

	public int GetThirst() {
		return this.thirst;
	}
}

