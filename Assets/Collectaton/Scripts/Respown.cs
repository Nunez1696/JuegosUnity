using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respown : MonoBehaviour {

	public GameObject prefab;

	void Start () {

		for (int i = 0; i <= 9; i++) {
			Vector2 position = new Vector2 (Random.Range (-100f, 200f), Random.Range (-172, 173));
				Instantiate (prefab, position, Quaternion.identity);
		
		}
	}
}