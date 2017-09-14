using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	[SerializeField] bool checador = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (checador) {
			if (Input.GetKey (KeyCode.W) && this.transform.position.y < 18.5f) {
		
				this.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, 15f);

			} else if (Input.GetKey (KeyCode.S) && this.transform.position.y > -17.5f) {

				this.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, -15f);

			} else {

				this.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, 0f);

			}
		}

		if (Input.GetKey (KeyCode.UpArrow) && this.transform.position.y < 18.5f) {

			this.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, 15f);

		}

		else if (Input.GetKey (KeyCode.DownArrow) && this.transform.position.y > -17.5f ) {

			this.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, -15f);

		} 
		else  {

			this.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, 0f);

		}

	}
	}


