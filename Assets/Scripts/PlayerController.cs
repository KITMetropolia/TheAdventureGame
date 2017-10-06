using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	public Player player;

	public GameObject pekka;

	public Weapon knife;
	public Weapon shotgun;
	public Weapon rifle;

	public Item carrot;
	public Item waterbottle;

	public Npc rabbit;

	public float speed;

	private Rigidbody2D rb2d;

	public Button bLeft;
	public Button bRight;
	public Button bUp;
	public Button bDown;

	private float moveHorizontal = 0.0f;
	private float moveVertical = 0.0f;

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

	}
	
	// Update is called once per frame
	void Update () {
		
		Vector2 movement = new Vector2 (moveHorizontal, moveVertical);

		rb2d.transform.Translate (movement * speed);

		moveHorizontal = 0.0f;
		moveVertical = 0.0f;
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.CompareTag ("Item")) {
			if (other.gameObject.name == "Carrot") {
				player.ChangeStats (carrot.heal, carrot.food, carrot.drink);
			}
			if (other.gameObject.name == "Waterbottle") {
				player.ChangeStats (waterbottle.heal, waterbottle.food, waterbottle.drink);
			}
			other.gameObject.SetActive (false);
		}
		if (other.gameObject.CompareTag ("Rabbit")) {
				player.ChangeHealth (rabbit.GetDamage ());
			Debug.Log (rabbit.GetDamage ());
		}
	}
}
