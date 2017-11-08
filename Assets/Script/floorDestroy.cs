using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floorDestroy : MonoBehaviour {

	public GameObject floor;
	public GameObject floorStart;
	public bool a;
	public int frame;

	void Update(){

		frame++;

		if(frame % 40 == 0){

			Instantiate (floor, floorStart.transform.position, Quaternion.identity);

		}

	}

}
