using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon2 : MonoBehaviour
{
    int atk = 1;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Idle1")
        {
            Idle1Manager idle1 = collision.gameObject.GetComponent<Idle1Manager>();
            idle1.damage(atk);
	   
        }
    }
}
