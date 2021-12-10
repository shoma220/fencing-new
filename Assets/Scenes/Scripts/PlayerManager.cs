using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public Animator Player; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow)) {
 		Player.transform.position -= new Vector3(1, 0);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow)) {
 		Player.transform.position += new Vector3(1, 0);
		if(Player.transform.position.x >= 7.0f){
			Player.transform.position=new Vector3(7,0);
		}
        }
        if (Input.GetKeyDown(KeyCode.Space)) {
 		Player.SetTrigger("IsAttack");
        }if (Input.GetKeyDown(KeyCode.B)) {
 		Player.SetTrigger("IsFant");
        }
	
    }
}
