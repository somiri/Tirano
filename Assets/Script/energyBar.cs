using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class energyBar : MonoBehaviour {



    // Update is called once per frame
    void Update() {
        if (FSM.gamePlay) { 
        if (floorManager.frame % 60 == 0 && FSM.hp > 0.0f) {
            GetComponent<Image>().fillAmount -= 0.01f;


        }
    }




	}



}

