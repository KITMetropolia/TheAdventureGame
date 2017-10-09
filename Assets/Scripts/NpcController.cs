using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcController : MonoBehaviour {

	public Player player;

	public Npc rabbit;

	//a variable to store this game object's Transform  
	private Transform myTransform;  
	//a variable to store the player's character Transform  
	private Transform playerTransform;  
	/*a static boolean variable to tell if the player has collided with 
    any enemy trigger*/  
	public static bool hasCollided = false; 

	//Initialization code  
	void Start()  
	{  
		//get the game object the script is attached to  
		myTransform = this.GetComponent<Transform>();  
		//get the player's Transform
		playerTransform = GameObject.FindWithTag("Player").GetComponent<Transform>();
	}  


	void Update()  
	{  
		if(this.name == "Rabbit")  
		{  
			Follow();  
		}  
	}

	//makes the enemy follow the player  
	private void Follow()  
	{  
		//only follow the player if this enemy is 3 units away from the player
		if(Vector2.Distance(myTransform.position, playerTransform.position) <= 3)  
		{  
			myTransform.position = Vector2.MoveTowards (myTransform.position, playerTransform.position, 0.5f * Time.deltaTime);
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
