using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpkk : MonoBehaviour {

    int frame;

	
	// Update is called once per frame
	void Update () {
        frame++;

        if (frame % 20 == 0)
            GetComponent<Rigidbody2D>().AddForce(Vector3.up * 100.0f);

	}
}
