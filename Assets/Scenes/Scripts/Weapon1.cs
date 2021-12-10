using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon1 : MonoBehaviour
{
    int atk = 1;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Idle2")
        {
            Idle2Manager idle2 = collision.gameObject.GetComponent<Idle2Manager>();
            idle2.damage(atk);
	   
        }
    }
}
