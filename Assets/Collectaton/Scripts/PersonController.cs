using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PersonController : MonoBehaviour {

	[SerializeField] public float speed;
	private int contador; 
	public Text ScorteText; 

	void Start () {
		
		contador = 0; 
		SetCountText (); 
	}
	

	void Update () {

		if (Input.GetKey (KeyCode.A)) {

			transform.Translate (Vector2.left * Time.deltaTime * speed);
		}

		if (Input.GetKey (KeyCode.D)) {

			transform.Translate (Vector2.right * Time.deltaTime * speed);

		}
	
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
