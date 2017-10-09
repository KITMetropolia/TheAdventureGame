using System;
using UnityEngine; 
using System.Collections;

public class Human : MonoBehaviour {

	private int health;
	public int damage = -20;

	void Start () {
		if (this.tag == "Human") {
			this.health = 150;
			this.damage = -25;

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

		
	}
}

