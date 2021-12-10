using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager2 : MonoBehaviour
{
    public Animator Player; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) {
 		Player.transform.position -= new Vector3(1, 0);
		if(Player.transform.position.x <= -7.0f){
			Player.transform.position=new Vector3(-7,0);
		}
        }
        if (Input.GetKeyDown(KeyCode.D)) {
 		Player.transform.position += new Vector3(1, 0);
        }
        if (Input.GetKeyDown(KeyCode.E)) {
 		Player.SetTrigger("IsAttack");
        }
	if (Input.GetKeyDown(KeyCode.Q)) {
 		Player.SetTrigger("IsFant");
        }
	
    }
}
