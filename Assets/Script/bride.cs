using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bride : MonoBehaviour {

	public Image bar;
	public GameObject face;
	public GameObject face1;
	public GameObject face2;
	int a = 1;

	void Update(){

		if (bar.GetComponent<Image> ().fillAmount <= 0.4f) {
			
			face.SetActive (false);
			face1.SetActive (true);
			if (transform.localPosition.x < -7.55f)
				a = -1;
			else if (transform.localPosition.x > -7.2f)
				a = 1;
			transform.Translate (Vector3.left * 2 * Time.deltaTime * a);

		}
		if (bar.GetComponent<Image> ().fillAmount <= 0.2f) {

			face1.SetActive (false);
			face2.SetActive (true);
			if (transform.localPosition.x < -7.55f)
				a = -1;
			else if (transform.localPosition.x > -7.2f)
				a = 1;

			transform.Translate (Vector3.left * 2 * Time.deltaTime * a);
			transform.Translate (Vector3.up * 2 * Time.deltaTime * a);
		
		}




	}

}
