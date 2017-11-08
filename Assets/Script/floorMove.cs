using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floorMove : MonoBehaviour {

	public static float speed;	
	public int frame;
	public float destroyTime;
	public int instantiateTime;
	public static float boosterSpeed;


	void Start(){
		if (FSM.gamePlay) {
			speed = 6.0f;
			destroyTime = 12.0f;
			boosterSpeed = speed * 2;
		}
	}

	// Update is called once per frame
	void Update () {

		if (FSM.gamePlay == false) {

			speed = 0.0f;

		}
		
		frame++;
		transform.Translate (Vector3.left * speed * Time.deltaTime);

	}

}
