using System;
using UnityEngine; 
using System.Collections;

public class Npc : MonoBehaviour {

	private int health;
	public int damage = -20;
	private Boolean isFriendly;

	void Awake () {
		if (tag == "Rabbit") {
			health = 10;
			damage = -10;
			isFriendly = false;
		}
		if (tag == "Human") {
			health = 100;
			damage = -100;
			isFriendly = false;
		}
	}

	public int GetHealth () {
		return this.health;
	}

	public void ChangeHealth (int amount) {
		health -= amount;
		if (health <= 0) {
			health = 0;
		}
	}

	public int GetDamage () {
		return this.damage;
	}

	public Boolean GetIsFriendly () {
		return this.isFriendly;
	}

	public void ChangeIsFriendly (Boolean status) {
		isFriendly = status;
	}
}
