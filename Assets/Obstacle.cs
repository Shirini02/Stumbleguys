using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{

	int speed = 6;
     void Start()
    {
        
    }
   void Update()
    {
        if(transform.position.x<-4)
        {
            speed = 4;
        }
        if(transform.position.x>4)
        {
            speed = -4;
        }
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }
}
