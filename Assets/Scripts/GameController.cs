using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	public GameObject pekka;

	public Player player;

	public Button bKnife;
	public Button bShotgun;
	public Button Rifle;

	public Text pname;
	public Text weapon;
	public Text health;
	public Text hunger;
	public Text thirst;

	public Text info;

	// Use this for initialization
	void Start () {
		//bKnife.onClick.AddListener (() => player.setWeapon ("Knife"));
		//bShotgun.onClick.AddListener (() => player.setWeapon ("Shotgun"));
		//bRifle.onClick.AddListener (() => player.setWeapon ("Rifle"));
	}
	
	// Update is called once per frame
	void Update () {
		ShowStats ();
	}

	// Shows player's statistics
	void ShowStats() {
		pname.text = "Hunter: " + player.GetName ();
		weapon.text = "Weapon: " + player.GetWeapon ();
		hunger.text = "Hunger: " + player.GetHunger ();
		thirst.text = "Thirst: " + player.GetThirst ();
		health.text = "Health: " + player.GetHealth ();
		if (player.GetHealth () == 0) {
			EndGame ();
		}
	}

	// If player dies
	public void EndGame() {
		info.text = "Pekka has died. Game over, man! Game over!";
		pekka.SetActive (false);
	}
}
