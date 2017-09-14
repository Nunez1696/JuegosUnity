using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoves : MonoBehaviour {

	[SerializeField] float speed;
	[SerializeField] int bullet;



	// Use this for initialization
	void Start () {


		
	}
	
	// Update is called once per frame
	void Update () {


		if (Input.GetKey (KeyCode.A) && transform.position.x > - 5.7f  ) {

			transform.Translate (Vector2.left * Time.deltaTime * speed);
		}

		if (Input.GetKey (KeyCode.D) && transform.position.x < 5.8f ) {

			transform.Translate (Vector2.right * Time.deltaTime * speed);
		}
			

		//if (Input.GetKey (KeyCode.Space)) {

			//Instantiate (bullet, transform.position, Quaternion.identity);
		}

}
