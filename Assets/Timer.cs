using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public GameObject textdisplay;
    public int seconds = 30;
    public bool takingAway = false;
     void Start()
    {
        textdisplay.GetComponent<Text>().text = "00:" + seconds;
    }
     private void Update()
    {
        if(takingAway==false && seconds>0)
        {
            StartCoroutine(Timertake());
        }
    }
    IEnumerator Timertake()
    {
        takingAway = true;
        yield return new WaitForSeconds(1);
        seconds =seconds-1;
        if (seconds < 10)
        {
            textdisplay.GetComponent<Text>().text = "00:0" + seconds;
        }
        else
        {
            textdisplay.GetComponent<Text>().text = "00:" + seconds;
        }
        takingAway = false;
    }
}
