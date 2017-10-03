using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	public GameObject player;

	public Player pekka;

	public Text pname;
	public Text weapon;
	public Text health;
	public Text hunger;
	public Text thirst;

	public Text info;

	// Use this for initialization
	void Start () {
		ShowStats ();
	}
	
	// Update is called once per frame
	void Update () {
		ShowStats ();
	}

	void ShowStats() {
		pname.text = "Hunter: " + pekka.GetName ();
		weapon.text = "Weapon: " + pekka.GetWeapon ();
		hunger.text = "Hunger: " + pekka.GetHunger ();
		thirst.text = "Thirst: " + pekka.GetThirst ();
		health.text = "Health: " + pekka.GetHealth ();
		if (pekka.GetHealth () == 0.0) {
			EndGame ();
		}
	}

	public void EndGame() {
		info.text = "Pekka has died. Game over, man! Game over!";
		player.SetActive (false);
	}
}
