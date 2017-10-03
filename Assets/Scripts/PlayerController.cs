using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	public Player pekka;

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

		bLeft.onClick.AddListener (() => ChangeStats (0.0f, 0.1f, 0.3f));
		bRight.onClick.AddListener (() => ChangeStats (0.0f, 0.1f, 0.3f));
		bUp.onClick.AddListener (() => ChangeStats (0.0f, 0.1f, 0.3f));
		bDown.onClick.AddListener (() => ChangeStats (0.0f, 0.1f, 0.3f));

	}
	
	// Update is called once per frame
	void Update () {
		
		Vector2 movement = new Vector2 (moveHorizontal, moveVertical);

		rb2d.transform.Translate (movement * speed);

		moveHorizontal = 0.0f;
		moveVertical = 0.0f;
	}

	void ChangeStats (float heal, float food, float drink) {
		pekka.ChangeHealth (heal);
		pekka.ChangeHunger (food);
		pekka.ChangeThirst (drink);
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.CompareTag ("Item")) {
			other.gameObject.SetActive (false);
		}
		if (other.gameObject.CompareTag ("Rabbit")) {
			other.gameObject.SetActive (false);
		}
	}
}
