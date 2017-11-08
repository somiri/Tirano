using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crush : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D c){

		if (c.transform.tag == "Player")
			GetComponent<Rigidbody2D> ().AddForce (new Vector3 (1000.0f, 1000.0f, 0));

	}
}
