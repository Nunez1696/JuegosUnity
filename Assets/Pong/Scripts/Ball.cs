using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	private Rigidbody2D rb;


	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody2D> ();
		rb.velocity = new Vector2 (20f, 20f);
	}
	
	// Update is called once per frame
	void Update () {

	}
}
	