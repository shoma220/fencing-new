using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller2 : MonoBehaviour
{
    float vx = 0;
    float vy = 0;

    public float speed = 30;
 	public GameObject Rect;
RectTransform rect;
    // Start is called before the first frame update
    void Start()
    {
 rect = Rect.GetComponent < RectTransform > ();
    }
 
    // Update is called once per frame
    void Update()
    {
        // 毎フレーム数値を初期化
        /*vx = 0;
        vy = 0;
 */
        // 横移動
        if (Input.GetKey(KeyCode.LeftArrow)) {
 rect.localPosition += new Vector3(10, 0, 0);
            //vx = -speed;
        } else if (Input.GetKey(KeyCode.RightArrow)) {
 rect.localPosition -= new Vector3(10, 0, 0);
            //vx = speed;
        }
 
 
        // 実際の移動処理
        //this.transform.Translate();
 //rect.localPosition += new Vector3(vx/50, vy/50, 0);
    }
}