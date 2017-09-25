using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	Player player = new Player();

	//player statistics
	Text pname;
	Text strength;
	Text health;
	Text hunger;
	Text thirst;

	//player
	private GameObject pekka;

	//buttons to move player
	private Button bLeft;
	private Button bRight;
	private Button bUp;
	private Button bDown;

	// Use this for initialization
	void Start () {

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

		//creates the player
		pekka = GameObject.Find ("Pekka");

		//creates the buttons to move player
		bLeft = GameObject.Find ("ButtonLeft").GetComponent<Button> ();
		bRight = GameObject.Find ("ButtonRight").GetComponent<Button> ();
		bUp = GameObject.Find ("ButtonUp").GetComponent<Button> ();
		bDown = GameObject.Find ("ButtonDown").GetComponent<Button> ();

		//controls how much the player is moving by every click
		bLeft.onClick.AddListener(() => pekka.transform.Translate(-1,0,0));
		bRight.onClick.AddListener (() => pekka.transform.Translate (1,0,0));
		bUp.onClick.AddListener (() => pekka.transform.Translate (0,1,0));
		bDown.onClick.AddListener (() => pekka.transform.Translate (0,-1,0));

		
	}
	
	// Update is called once per frame
	void Update () {


		
	}
}
