using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	public Player player;

	public GameObject pekka;

	public Text info;

	public Item carrot;
	public Item waterbottle;

	public Npc rabbit;
	
	public Npc human;

	public float speed;

	private Rigidbody2D rb2d;

	public Button bLeft;
	public Button bRight;
	public Button bUp;
	public Button bDown;

	public Button bAttack;

	private float moveHorizontal = 0.0f;
	private float moveVertical = 0.0f;

	public Text cname;
	public Text dialogue;

	private Image image1;
	private Image image2;
	private Image image3;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();

		bLeft.onClick.AddListener (() => moveHorizontal = -0.1f);
		bRight.onClick.AddListener (() => moveHorizontal = 0.1f);
		bUp.onClick.AddListener (() => moveVertical = 0.1f);
		bDown.onClick.AddListener (() => moveVertical = -0.1f);

		bLeft.onClick.AddListener (() => player.ChangeStats (0, 1, 3));
		bRight.onClick.AddListener (() => player.ChangeStats (0, 1, 3));
		bUp.onClick.AddListener (() => player.ChangeStats (0, 1, 3));
		bDown.onClick.AddListener (() => player.ChangeStats (0, 1, 3));

		bAttack.onClick.AddListener (() => Attack ());

		image1 = GameObject.Find ("Image1").GetComponent<Image> ();
		image2 = GameObject.Find ("Image2").GetComponent<Image> ();
		image3 = GameObject.Find ("Image3").GetComponent<Image> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate () {
			
		Vector2 movement = new Vector2 (moveHorizontal, moveVertical);

		rb2d.transform.Translate (movement * speed);

		moveHorizontal = 0f;
		moveVertical = 0f;

	}

	void Attack () {
		
	}

	// When player collides with something
	void OnTriggerEnter2D(Collider2D other) {

		// Player collides with finish marker
		if (other.gameObject.CompareTag ("Finish") && image1.sprite.name == "key" && image2.sprite.name == "phone" && image3.sprite.name == "watch") {
			info.text = "Pekka! You won a win!";
		}

		// Player collides with item
		if (other.gameObject.CompareTag ("Item")) {
			if (other.gameObject.name == "Carrot") {
				player.ChangeStats (carrot.heal, carrot.food, carrot.drink);
			}
			if (other.gameObject.name == "Waterbottle") {
				player.ChangeStats (waterbottle.heal, waterbottle.food, waterbottle.drink);
			}
			other.gameObject.SetActive (false);
		}

		// Player collides with rabbit
		if (other.gameObject.CompareTag ("Rabbit")) {
			bAttack.onClick.AddListener (() => other.gameObject.SetActive (false));
			player.ChangeHealth (rabbit.damage);
		}
		// Player collides with human
		if (other.gameObject.CompareTag ("Human")) {
			bAttack.onClick.AddListener (() => other.gameObject.SetActive (false));
			player.ChangeHealth (human.damage);
		}
	}
}
