using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PersonController : MonoBehaviour {

	private Rigidbody2D rb; 
	public float speed;
	private int contador; 
	public Text ScorteText; 

	void Start () {

		rb = GetComponent<Rigidbody2D>();
		contador = 0; 
		SetCountText (); 
	}
	

	void FixedUpdate () {

		float MovHorizontal = Input.GetAxis ("Horizontal");
		float MovVertical = Input.GetAxis ("Vertical");

		Vector2 Movimiento = new Vector2 (MovHorizontal, MovVertical);

		rb.AddForce (Movimiento * speed);

	}

	void OnTriggerEnter2D(Collider2D other){

			Destroy (other.gameObject);
			contador = contador + 1; 
			SetCountText ();
	
	}

	void SetCountText (){
	
		ScorteText.text = "Tomates: " + contador.ToString (); 
	
	}
}
