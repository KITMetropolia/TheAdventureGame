using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

	//player's initial stats
	private string pname = "Pekka";
	private double strength = 100.0;
	private double health = 100.0;
	private double hunger = 0.0;
	private double thirst = 0.0;
	private Weapon primaryWeapon = new Weapon(1);

	//private GameObject triggeringNPC;
	private bool triggering;

	//public GameObject NPCText;

	public Player ()
	{
		
	}

	public string GetName() {
		return this.pname;
	}

	public void SetName(string newName) {
		pname = newName;
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
/*
	void update () {
		if (OnTriggering) {

		}
	}

	void OnTriggering (Collider other) {
		if (other.tag == "NPC") {
			OnTriggering = true;
			triggeringNpc = other.gameObject;
		}
	}

	void OnTriggerExit (Collider other) {
		if (other.tag == "NPC") {
			OnTriggering = false;
			triggeringNpc = null;
		}
	}
	*/
}

