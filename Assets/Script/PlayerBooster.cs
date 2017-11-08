using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerBooster : MonoBehaviour {

	public int skillTime;
	public int boosterCoolDown;
	public int boosterframe;
	public int boosterSkillframe;
	public bool skill;

	// Use this for initialization
	void Start () {

		boosterCoolDown = 10;

		skillTime = 3000;

		skill = false;

	}
	
	// Update is called once per frame
	void Update () {

		if (boosterCoolDown > 0)
			boosterframe++;

		if (boosterframe % 60 == 0 && boosterCoolDown > 0)
			boosterCoolDown -= 1;



		
		if (floorMove.speed == floorMove.boosterSpeed)
			skill = false;

		if (skill == false) {

			boosterCoolDown = 10;
			boosterframe = 0;
			boosterSkillframe++;

		}


	}

		public void booster(){

			if (boosterCoolDown == 0) {

				skill = true;
				floorMove.speed = floorMove.boosterSpeed;

			}

		}

	}

