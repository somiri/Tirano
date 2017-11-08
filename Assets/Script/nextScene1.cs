using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextScene1 : MonoBehaviour {
    public GameObject end;
    void OnTriggerEnter2D(Collider2D c)
    {

        if(c.transform.tag == "i")
            SceneManager.LoadScene("end");
    }
    }
