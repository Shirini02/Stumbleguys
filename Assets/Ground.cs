using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    int speed = 6;
    void Start()
    {

    }
    void Update()
    {
        if (transform.position.y <=-1)
        {
            speed = 4;
        }
        if (transform.position.y> 3)
        {
            speed = -4;
        }
        transform.Translate(0, speed * Time.deltaTime, 0);
    }
}
