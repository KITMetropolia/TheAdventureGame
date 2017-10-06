using System;
using UnityEngine; 
using System.Collections;

public class Npc : MonoBehaviour {

	private int health;
	public int damage = -20;
	private Boolean isFriendly;

	void Start () {
		if (this.tag == "Rabbit") {
			this.health = 10;
			this.damage = -10;
			this.isFriendly = false;
		}
	}

	public int GetHealth () {
		return this.health;
	}

	public void ChangeHealth (int amount) {
		this.health -= amount;
	}

	public int GetDamage () {
		return this.damage;
	}

	public Boolean GetIsFriendly () {
		return this.isFriendly;
	}

	public void ChangeIsFriendly (Boolean status) {
		this.isFriendly = status;
	}
}
