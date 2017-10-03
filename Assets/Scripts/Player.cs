using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public string pname = "Pekka";
	public string weapon = "Knife";
	public float health = 100.0f;
	public float hunger = 0.0f;
	public float thirst = 0.0f;

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

	public float GetHealth() {
		return this.health;
	}

	public void ChangeHealth(float amount) {
		health += amount;
		if (health > 100.0f) {
			health = 100.0f;
		}
		if (health <= 0.0f) {
			health = 0.0f;
		}
	}

	public float GetHunger() {
		return this.hunger;
	}

	public void ChangeHunger(float amount) {
		hunger += amount;
		if (hunger > 100.0f) {
			hunger = 100.0f;
			ChangeHealth (-1.0f);
		}
		if (hunger < 0.0f) {
			hunger = 0.0f;
		}
	}

	public float GetThirst() {
		return this.thirst;
	}

	public void ChangeThirst(float amount) {
		thirst += amount;
		if (thirst > 100.0f) {
			thirst = 100.0f;
			ChangeHealth (-1.0f);
		}
		if (thirst < 0.0f) {
			thirst = 0.0f;
		}
	}

}
