using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundRespawn : MonoBehaviour {

	public GameObject bg;
	public GameObject start;

	void Start(){

		bg = GameObject.Find ("배경");
		start = GameObject.Find ("배경 생성");

	}

	void OnTriggerEnter2D(Collider2D c){

		if (c.transform.tag == "BackGroundEnd") {
		
			Instantiate (bg, start.transform.position, Quaternion.identity);

		}
	}
}
