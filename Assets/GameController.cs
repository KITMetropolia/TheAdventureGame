using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	Player player;

	//player statistics
	Text pname;
	Text strength;
	Text health;
	Text hunger;
	Text thirst;
	Text weapon;

	//buttons to move player
	Button bLeft;
	Button bRight;
	Button bUp;
	Button bDown;

	//buttons to change weapons
	Button bKnife;
	Button bShotgun;
	Button bRifle;

	//List of items
	Item carrot;
	Item waterbottle;

	Text info;

	// Use this for initialization
	void Start () {
		info = GameObject.Find ("Info").GetComponent<Text> ();

		//creates the player
		player = GameObject.Find ("Pekka").AddComponent<Player> ();

		//show statistics of player
		pname = GameObject.Find ("Name").GetComponent<Text> ();
		pname.text = "Hunter: " + player.GetName ();
		strength = GameObject.Find ("Strength").GetComponent<Text> ();
		strength.text = "Strength: " + player.GetStrength ();
		health = GameObject.Find ("Health").GetComponent<Text> ();
		health.text = "Health: " + player.GetHealth ();
		hunger = GameObject.Find ("Hunger").GetComponent<Text> ();
		hunger.text = "Hunger: " + player.GetHunger ();
		thirst = GameObject.Find ("Thirst").GetComponent<Text> ();
		thirst.text = "Thirst: " + player.GetThirst ();
		weapon = GameObject.Find ("Weapon").GetComponent<Text> ();
		weapon.text = "Weapon: " + player.GetPrimaryWeapon ().GetName ();

		//creates the buttons to move player
		bLeft = GameObject.Find ("ButtonLeft").GetComponent<Button> ();
		bRight = GameObject.Find ("ButtonRight").GetComponent<Button> ();
		bUp = GameObject.Find ("ButtonUp").GetComponent<Button> ();
		bDown = GameObject.Find ("ButtonDown").GetComponent<Button> ();

		//controls how much the player is moving by every click
		bLeft.onClick.AddListener(() => MovePekka("left"));
		bRight.onClick.AddListener (() => MovePekka("right"));
		bUp.onClick.AddListener (() => MovePekka("up"));
		bDown.onClick.AddListener (() => MovePekka("down"));

		//creates the buttons to change weapons
		bKnife = GameObject.Find ("BKnife").GetComponent<Button> ();
		bRifle = GameObject.Find ("BRifle").GetComponent<Button> ();
		bShotgun = GameObject.Find ("BShotgun").GetComponent<Button> ();

		//controls weapon changing
		bKnife.onClick.AddListener(() => ChangeWeapon(1));
		bRifle.onClick.AddListener(() => ChangeWeapon(2));
		bShotgun.onClick.AddListener(() => ChangeWeapon(3));

		carrot = GameObject.Find ("Carrot").AddComponent<Item> ();
		carrot.SetItemStats (1);

		waterbottle = GameObject.Find ("Waterbottle").AddComponent<Item> ();
		waterbottle.SetItemStats (2);
		
	}

	void ShowStats() {
		pname.text = "Hunter: " + player.GetName ();
		strength.text = "Strength: " + player.GetStrength ();
		hunger.text = "Hunger: " + player.GetHunger ();
		thirst.text = "Thirst: " + player.GetThirst ();
		health.text = "Health: " + player.GetHealth ();
		weapon.text = "Weapon: " + player.GetPrimaryWeapon ().GetName ();
		if (player.GetHealth () == 0.0) {
			EndGame ();
		}
	}

	void MovePekka(string direction) {
		if (direction == "left") {
			player.transform.Translate (-1, 0, 0);
		}
		if (direction == "right") {
			player.transform.Translate (1, 0, 0);
		}
		if (direction == "up") {
			player.transform.Translate (0, 1, 0);
		}
		if (direction == "down") {
			player.transform.Translate (0,-1,0);
		}
		player.ChangeHunger (1);
		player.ChangeThirst (3);
		ShowStats ();
	}

	//changes a weapon
	void ChangeWeapon(int set) {
		player.SetPrimaryWeapon (set);
		ShowStats ();
	}
	
	// Update is called once per frame
	void Update () {

		
	}

	public void EndGame() {
		info.text = "Pekka has died. Game over, man! Game over!";
	}
}
