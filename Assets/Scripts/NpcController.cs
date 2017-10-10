using System.Collections;
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

	private void Speak () {
		
		if (this.name == "Moose1") {
			if (Vector2.Distance (myTransform.position, playerTransform.position) <= 2) {
				cname.text = this.name.ToString ();
				dialogue.text = "Tässä tulee totta vieköön tärkeää asiaa!";
			}
			if (Vector2.Distance (myTransform.position, playerTransform.position) > 2) {
				cname.text = "";
				dialogue.text = "";
			}
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
