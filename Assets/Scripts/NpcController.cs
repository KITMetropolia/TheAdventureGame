﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NpcController : MonoBehaviour {

	public Player player;

	public Npc rabbit;

	public Npc moose;

	public Text cname;
	public Text dialogue;

	//a variable to store this game object's Transform  
	private Transform myTransform;  
	//a variable to store the player's character Transform  
	private Transform playerTransform;  
	/*a static boolean variable to tell if the player has collided with 
    any enemy trigger*/  
	public static bool hasCollided = false;

	private Button bAttack;

	private Button answerA;
	private Button answerB;
	private Button answerC;

	//Initialization code  
	void Start()  
	{  
		//get the game object the script is attached to  
		myTransform = this.GetComponent<Transform>();  
		//get the player's Transform
		playerTransform = GameObject.FindWithTag("Player").GetComponent<Transform>();

		cname = GameObject.Find ("Name").GetComponent<Text> ();
		dialogue = GameObject.Find ("Dialogue").GetComponent<Text> ();

		bAttack = GameObject.Find ("ButtonAttack").GetComponent<Button> ();
	
		answerA = GameObject.Find ("AnswerA").GetComponent<Button> ();
		answerB = GameObject.Find ("AnswerB").GetComponent<Button> ();
		answerC = GameObject.Find ("AnswerC").GetComponent<Button> ();


	}  


	void Update()
	{  

		if (this.tag == "Rabbit")  
		{  
			Follow();
		}

		if (this.tag == "Human") {
			Follow ();
		}

		if (this.tag == "Moose") {
			Speak ();
		}
	}

	//makes the enemy follow the player  
	private void Follow()  
	{  
		//only follow the player if this enemy is 3 units away from the player
		if (Vector2.Distance(myTransform.position, playerTransform.position) <= 3)  
		{  
			myTransform.position = Vector2.MoveTowards (myTransform.position, playerTransform.position, 0.8f * Time.deltaTime);
			cname.text = this.name.ToString ();
			if (this.tag == "Human") {
				dialogue.text = "Nyt lähtee henki!";
			}
			if (this.tag == "Rabbit") {
				dialogue.text = "RRROOAAARRRGHHH!!!";
			}
		}

		if (Vector2.Distance(myTransform.position, playerTransform.position) <= 2) {
			bAttack.onClick.AddListener (() => Attack ());
		}

	}

	public void Attack () {
		this.gameObject.SetActive (false);
	}

	public void Speak () {
		
		if (this.name == "Moose1") {
			if (Vector2.Distance (myTransform.position, playerTransform.position) <= 2) {

				ShowDialogue ("Mr Moose", "Hello Stranger! Welcome to our forrest! I will help you! You have to collect certain items and " +
					"to do that you have to find every moose in the forrest. Each of them will tell you a riddle and you have to solve it to be " +
					"able to get a item from the moose.\nYou need to be careful, there are evil creatures in the forest that will try to eat you! " +
					"Anyways here is the first riddle: Take off my skin – I won’t cry, but you will! What am I?   \nA= apple , B= human or C= onion?");
				//answerA.onClick.AddListener (() => );
				//answerB.onClick.AddListener (() => );
				//answerC.onClick.AddListener (() => );


			}
			if (Vector2.Distance (myTransform.position, playerTransform.position) > 2) {
				cname.text = "";
				dialogue.text = "";

			}
		}

		if (this.name == "Moose2") {
			ShowDialogue ("Mrs Moose", "Hello Human! You are not one of those gangsters are you? You dont look like them so, Bob’s father has 4 children. " +
				"Momo, Meme, and Mumu are three of them. Who’s the fourth?. A=Mimu B=Bob or C=Mame  ?");

		}

		if (this.name == "Moose3") {
			ShowDialogue ("Ms Moose", "Hello! You look like you need help. Alright, Your dad tells you that he will pay you $6.00 an hour for the 6 seconds " +
				"that you take to wash your hands before dinner.\nHow much did you make for washing your hands? A=1 cnt , B= 10 cnt or C= 11cnt?");

		}
	}

	public void ShowDialogue (string ch, string dial) {
		cname.text = ch;
		dialogue.text = dial;
	}

	public void SetAnswerButtonsActivity (bool set) {
		if (set == true) {
			
		}
		if (set == false) {
			
		}
	}

	void OnTriggerEnter2D(Collider2D other)  
	{  
		//if the player collided with the trigger  
		if(other.gameObject.tag=="Player")  
		{  
			//set hasCollided static variable to true  
			hasCollided = true;
		}  
	}
}
