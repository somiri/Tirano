using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roadRespawn : MonoBehaviour {

	public GameObject[] easy;
	public GameObject start;
	public int random;
	public int frame;
	void Start(){
		
		GameObject[] easy = new GameObject[100];
		start = GameObject.Find ("생성");

	}

	void Update(){

		random = Random.Range (0, 22);


	}

	void OnTriggerEnter2D(Collider2D c){

		if (c.transform.tag == "floorEnd") {

			Instantiate (easy [random], start.transform.position, Quaternion.identity);
			Debug.Log (random);
		}

	}
}
