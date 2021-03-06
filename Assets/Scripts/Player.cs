﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	private string pname = "Pekka";
	private string weapon = "Knife";
	private int health = 500;
	private int hunger = 0;
	private int thirst = 0;

	private const int maxHealth = 500;
	private const int maxHunger = 500;
	private const int maxThirst = 500;

	public Player () {

	}

	public string GetName() {
		return this.pname;
	}

	public void SetName(string newName) {
		pname = newName;
	}

	public string GetWeapon() {
		return this.weapon;
	}

	public void setWeapon(string newWeapon) {
		weapon = newWeapon;
	}

	public int GetHealth() {
		return this.health;
	}

	public void ChangeHealth(int amount) {
		health += amount;
		if (health > maxHealth) {
			health = maxHealth;
		}
		if (health <= 0) {
			health = 0;
		}

	}

	public int GetHunger() {
		return this.hunger;
	}

	public void ChangeHunger(int amount) {
		hunger += amount;
		if (hunger > maxHunger) {
			hunger = maxHunger;
			ChangeHealth (-1);
		}
		if (hunger < 0) {
			hunger = 0;
		}
	}

	public int GetThirst() {
		return this.thirst;
	}

	public void ChangeThirst(int amount) {
		thirst += amount;
		if (thirst > maxThirst) {
			thirst = maxThirst;
			ChangeHealth (-1);
		}
		if (thirst < 0) {
			thirst = 0;
		}
	}
		
	public void ChangeStats (int heal, int food, int drink) {
		ChangeHealth (heal);
		ChangeHunger (food);
		ChangeThirst (drink);
	}
}
