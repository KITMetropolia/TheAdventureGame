﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NpcController : MonoBehaviour {

	public Player player;

	public Npc rabbit;

	public Npc moose;

	private Text cname;
	private Text cname1;
	private Text dialogue;
	private Text dialogue1;

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

	private AudioSource mooseAudio;
	private AudioSource rabbitAudio;
	private AudioSource humanAudio;

	private Image image1;
	private Image image2;
	private Image image3;

	//Initialization code  
	void Start()  
	{  
		//get the game object the script is attached to  
		myTransform = this.GetComponent<Transform>();  
		//get the player's Transform
		playerTransform = GameObject.FindWithTag("Player").GetComponent<Transform>();

		cname = GameObject.Find ("Name").GetComponent<Text> ();
		cname1 = GameObject.Find ("Name1").GetComponent<Text> ();
		dialogue = GameObject.Find ("Dialogue").GetComponent<Text> ();
		dialogue1 = GameObject.Find ("Dialogue1").GetComponent<Text> ();

		bAttack = GameObject.Find ("ButtonAttack").GetComponent<Button> ();
	
		answerA = GameObject.Find ("AnswerA").GetComponent<Button> ();
		answerB = GameObject.Find ("AnswerB").GetComponent<Button> ();
		answerC = GameObject.Find ("AnswerC").GetComponent<Button> ();

		mooseAudio = GetComponent<AudioSource> ();
		rabbitAudio = GetComponent<AudioSource> ();
		humanAudio = GetComponent<AudioSource> ();

		image1 = GameObject.Find ("Image1").GetComponent<Image> ();
		image2 = GameObject.Find ("Image2").GetComponent<Image> ();
		image3 = GameObject.Find ("Image3").GetComponent<Image> ();
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
				humanAudio.Play ();
				dialogue.text = "Nyt lähtee henki!";
			}
			if (this.tag == "Rabbit") {
				rabbitAudio.Play ();
				dialogue.text = "RRROOAAARRRGHHH!!!";
			}
		}

		if (Vector2.Distance(myTransform.position, playerTransform.position) <= 1) {
			bAttack.onClick.AddListener (() => Attack ());
		}

	}

	public void Attack () {
		this.gameObject.SetActive (false);
	}

	public void Speak () {

		if (Vector2.Distance (myTransform.position, playerTransform.position) <= 2) {
			mooseAudio.Play ();
		}

		if (this.name == "Moose1") {


			if (Vector2.Distance (myTransform.position, playerTransform.position) <= 2.5) {

				ShowDialogue ("Mr Moose", "Hello Stranger! Welcome to our forest! I will help you! You have to collect certain items and " +
					"to do that you have to find every moose in the forest. Each of them will tell you a riddle and you have to solve it to be " +
					"able to get a item from the moose.\nYou need to be careful, there are evil creatures in the forest that will try to eat you! " +
					"Anyways here is the first riddle: Take off my skin – I won’t cry, but you will! What am I?   \nA= apple , B= human or C= onion?");
				//answerA.onClick.AddListener (() => );
				//answerB.onClick.AddListener (() => );
				answerC.onClick.AddListener (() => ChangeImage(image1, "key"));


			}
			if (Vector2.Distance (myTransform.position, playerTransform.position) > 2.5) {

				cname.text = "";
				dialogue.text = "";

			}
		}

		if (this.name == "Moose2") {
			
			if (Vector2.Distance (myTransform.position, playerTransform.position) <= 2.5) {
				
				cname1.text = "Mrs Moose";
				dialogue1.text = "Hello Human! You are not one of those gangsters are you? You dont look like them so, Bob’s father has 4 children. " +
				"Momo, Meme, and Mumu are three of them. Who’s the fourth?. A=Mimu B=Bob or C=Mame  ?";
                              //answerA.onClick.AddListener (() => );
			      //answerC.onClick.AddListener (() => );
			      answerB.onClick.AddListener (() => ChangeImage(image2, "phone"));
		}
			if (Vector2.Distance (myTransform.position, playerTransform.position) >= 2) {
				
				cname1.text = "";
				dialogue1.text = "";
			}
		}		

		if (this.name == "Moose3") {
			
			if (Vector2.Distance (myTransform.position, playerTransform.position) <= 2.5) {
				
				ShowDialogue ("Ms Moose", "Hello! You look like you need help. A mouse runs 10 meters in 20 seconds." +
				"what is the mouses average speed?  A=0.5m/s , B=1.5m/s  or C= 2.0m/s");
				//answerB.onClick.AddListener (() => );
				//answerC.onClick.AddListener (() => );
				answerA.onClick.AddListener (() => ChangeImage (image3, "watch"));	
			}
			/*if (Vector2.Distance (myTransform.position, playerTransform.position) >= 2) {
				
				cname.text = "";
				dialogue.text = "";
			}*/
		}
			
	}

	public void ChangeImage (Image image, string item) {
		image.sprite = Resources.Load<Sprite> (item);
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
