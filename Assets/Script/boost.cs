using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class boost : MonoBehaviour, IPointerDownHandler, IPointerUpHandler {

	bool buttonDown = false;
	public int frame;



	void Update(){



		if (buttonDown) {

			GetComponent<Image> ().fillAmount += 0.01f;
			floorMove.speed = 12.0f;
			if (buttonDown == false)
				GetComponent<Image> ().fillAmount = 1.0f;
			
		} else if (buttonDown == false) {
			
			floorMove.speed = 6.0f;

			if (GetComponent<Image> ().fillAmount == 1.0f) {
				
				frame++;
				floorMove.speed = 6.0f;

			}





			if (frame % 600 == 0)
				GetComponent<Image> ().fillAmount = 0.0f;

		}
	}

	public void OnPointerDown(PointerEventData ped){

		buttonDown = true;
		if (GetComponent<Image> ().fillAmount >= 1.0f)
			buttonDown = false;

	}

	public void OnPointerUp(PointerEventData ped){

		buttonDown = false;
		if (buttonDown == false)
			GetComponent<Image> ().fillAmount = 1.0f;

	}

}
