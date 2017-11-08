using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundMove : MonoBehaviour {


	// Update is called once per frame
	void Update () {

		if(FSM.gamePlay)
		transform.Translate (Vector3.left * 5/4f * Time.deltaTime);
		
	}
}
