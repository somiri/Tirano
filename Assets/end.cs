using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class end : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D c){

		if (c.transform.tag == "Player")
			Destroy (c.transform);


	}

}
