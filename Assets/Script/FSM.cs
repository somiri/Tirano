using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FSM : MonoBehaviour {

	public float dist;
	public int jumpStatus;
	public int frame;
	public float jumpSpeed;
	public static int hp;
	public static bool gamePlay = true;
	public GameObject Camera;
	public GameObject floor;
	public Image bar;
	public Image[] i,j,k;
	public Image[] taxi;
	public bool t;
	public bool a;
	public bool g;
	public bool x;
	public bool e;
	public Image Taxi;
	int asd = 0;
	int asdf = 0;
	int asdg = 0;
    public GameObject endZone;
    public Image poor;
    public Image good;
    
	public bool[] item1;
	public bool[] item2;
	public bool[] item3;

	public int random;
	bool isSuccess = true;

    public Image[] phone;

    public int callFrame;
    public int katalkFrame;

    public bool isCall;
    public bool isKatalk;

    public Image[] endImage;
    public GameObject endI;
    public GameObject pa;
    
    public GameObject endEnd;

    public AudioClip boom;
    public AudioClip BGMBefore;
    public AudioClip jumpSound;


	void Start(){

        

		jumpSpeed = 45000.0f;
		hp = 120;
		gamePlay = true;


		i [0].enabled = false;
		i [1].enabled = false;
		i [2].enabled = false;

		j [0].enabled = false;
		j [1].enabled = false;
		j [2].enabled = false;

		k [0].enabled = false;
		k [1].enabled = false;
		k [2].enabled = false;

		taxi [0].enabled = false;
		taxi [1].enabled = false;
		taxi [2].enabled = false;
		taxi [3].enabled = false;
		taxi [4].enabled = false;

		item1 [0] = false;
		item1 [1] = false;
		item1 [2] = false;


		item2 [0] = false;
		item2 [1] = false;
		item2 [2] = false;


		item3 [0] = false;
		item3 [1] = false;
		item3 [2] = false;

        poor.enabled = true;
        good.enabled = false;

        phone[0].enabled = false;
        phone[1].enabled = false;
        phone[2].enabled = false;
        phone[3].enabled = false;
        phone[4].enabled = false;
        phone[5].enabled = false;

        
        endImage[0].enabled = false;
        endImage[1].enabled = false;
        endImage[2].enabled = false;

        endI.SetActive(false);
        pa.SetActive(false);
    }

	void Update(){
		
		dist = Vector3.Distance (floor.transform.position, this.transform.position);

        endZone.transform.Translate(Vector3.left * Time.deltaTime * 2.0f);

		random = Random.Range (0, 1);

        if (isCall)
        {
            callFrame++;
            phone[0].enabled = true;
            if (callFrame % 360 == 0)
            {

                phone[0].enabled = false;
                phone[1].enabled = true;

            }

            if (callFrame % 420 == 0)
            {
                phone[1].enabled = false;
                phone[0].enabled = false;
                isCall = false;
            }

        }
        if (isKatalk)
        {

            katalkFrame++;
            phone[2].enabled = true;
            if(katalkFrame % 60 == 0)
            phone[3].enabled = true;
            if (katalkFrame % 120 == 0)
                phone[4].enabled = true;
            if (katalkFrame % 180 == 0)
                phone[5].enabled = true;

            if (katalkFrame % 240 == 0)
            {
                phone[2].enabled = false;
                phone[3].enabled = false;
                phone[4].enabled = false;
                phone[5].enabled = false;
                isKatalk = false;
            }

           

        }

		if (((t && a) && (g && x)) && e){
				
				Taxi.enabled = true;
			
			}
		if ((((item1 [0] && item2 [0]) && item3 [0]) && ((item1 [1] && item2 [1]) && item3 [1])) && ((item1 [2] && item2 [2]) && item3 [2])) {
            if (isSuccess)
                ChangeClothes ();
		}


			if (jumpStatus > 1) {
			 
				frame++;

			}

			else if (dist <= 2.3f) {
			
				frame = 0;
				jumpStatus = 0;
				if (jumpStatus == 1)
					jumpStatus = 0;
			
			}

		if (bar.GetComponent<Image> ().fillAmount <= 0) {
			
			gamePlay = false;
            endImage[0].enabled = true;
            endImage[1].enabled = true;
            endImage[2].enabled = true;
            pa.SetActive(true);

        }



    }
	void ChangeClothes(){
        isSuccess = false;
        changeAni(1);
        endZone.SetActive(true);
        poor.enabled = false;
        good.enabled = true;
        endI.SetActive(true);
    }
		
   
    void changeAni(int AniNumber)
    {

        GetComponent<Animator>().SetInteger("PlayerAnim", AniNumber);

    }

	// Update is called once per frame
	public void Jump () {
	
		if (jumpStatus < 1 && gamePlay) {

			GetComponent<Rigidbody2D> ().AddForce (Vector3.up * jumpSpeed);
			jumpStatus++;


		}

	}

    void OnCollisionEnter2D(Collision2D c) {

        if (c.transform.tag == "end") {
            gamePlay = false;
        endImage[0].enabled = true;
        endImage[1].enabled = true;
        endImage[2].enabled = true;
            pa.SetActive(true);

        }

        if (c.transform.tag == "Crush")
        {
            Debug.Log("1");
            bar.GetComponent<Image>().fillAmount -= 0.06f;
            jumpStatus = 0;
        }

        else if (c.transform.tag == "topItem")
        {

            Destroy(c.gameObject);


            if (asd <= 2)
            {
                Debug.Log(asd);
                i[asd].enabled = true;
                item1[asd] = true;

                asd = asd + 1;
            }





        }

		if (c.transform.tag == "shirt") {
			
			Destroy (c.gameObject);


			if (asdf <= 2) {
				Debug.Log (asd);
				j [asdf].enabled = true;
				item2 [asdf] = true;

				asdf = asdf + 1;

			}

		}

		if (c.transform.tag == "bottom") {
			
			Destroy (c.gameObject);


			if (asdg <= 2) {
				Debug.Log (asd);
				k [asdg].enabled = true;
				item3 [asdg] = true;

				asdg = asdg + 1;

			}
		}


		if (c.transform.tag == "end") {

			Destroy (gameObject);
			floorMove.speed = 0f;

		}

        if(c.transform.tag == "call")
        {
            isCall = true;
            bar.GetComponent<Image>().fillAmount += 0.2f;
            Destroy(c.gameObject);
        }

        if(c.transform.tag == "katalk")
        {

            isKatalk = true;
            bar.GetComponent<Image>().fillAmount += 0.2f;
            Destroy(c.gameObject);
        }



	}



}
