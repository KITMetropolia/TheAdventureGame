using System;
using UnityEngine; 
using System.Collections;

public class Npc : MonoBehaviour {

	public Player player;

	public int health;
	public Boolean isFriendly;

	//a variable to store this game object's Transform  
	private Transform myTransform;  
	//a variable to store the player's character Transform  
	private Transform playerTransform;  
	/*a static boolean variable to tell if the player has collided with 
    any enemy trigger*/  
	public static bool hasCollided = false;  

	//Initialization code  
	void Awake()  
	{  
		//get the game object the script is attached to  
		myTransform = this.GetComponent<Transform>();  
		//get the player's Transform
		playerTransform = player.GetComponent<Transform> ();
		//playerTransform = GameObject.FindWithTag("Player").GetComponent<Transform>();  
	}  


	void Update()  
	{  

		if(hasCollided)  
		{  

			Follow();  
		}  
	}

	public void ChangeHealth (int amount) {
		health -= amount;
		if (health <= 0) {
			gameObject.SetActive (false);
		}
	}

	//makes the enemy follow the player  
	private void Follow()  
	{  
		//look at the player  
		myTransform.LookAt(playerTransform);  

		/*only follow the player if this enemy is  
        4.5 units away from the player*/  
		if(Vector3.Distance(myTransform.position,playerTransform.position)>=4.5f)  
		{  
			//move the enemy  
			myTransform.Translate(Vector3.forward * Time.deltaTime* 0.5f);  
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
