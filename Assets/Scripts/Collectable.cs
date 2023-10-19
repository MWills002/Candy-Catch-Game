using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public static int totalCoins = 0;


    void awake()
    {
        //Checks Collision
        GetComponent<Collider2D>().isTrigger = true;
    }

    public void OnCollisionEnter2D(Collision2D collision2D)
    {
        if (collision2D.gameObject.tag == "Ground")
        {
            Destroy(this.gameObject);
           // totalCoins++;
        }
        
        if (collision2D.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
            totalCoins++;
        }


    }
}





