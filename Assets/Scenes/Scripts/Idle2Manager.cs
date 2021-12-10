using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Idle2Manager : MonoBehaviour
{
    // Start is called before the first frame update
    int hp = 15;
    int point = 0; 
    public Image Maru;
    public GameObject Enemy;
    public GameObject Me;
    public GameObject Win; 
    public Text Life;
  
    void Start()
    {
	Maru.gameObject.SetActive(false);
	Win.SetActive(false);
	Life.text=point.ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void damage(int damage){
	hp -= damage;
	Debug.Log("敵のHP"+hp);
	point++;
	Life.text=point.ToString();
	if(hp<=0){
		Win.SetActive(true);
	}else{
		StartCoroutine("Seikai");
		Enemy.transform.position = new Vector3(2,0);
		Me.transform.position = new Vector3(-2,0);
	}
   }
   IEnumerator　Seikai(){
        Maru.gameObject.SetActive(true);
        Color c = Maru.color;
        c.a = 1f; 
        Maru.color = c; // 画像の不透明度を1にする
        yield return new WaitForSeconds(0.3f);
        while (true)
        {
            yield return null; // 1フレーム待つ
            c.a -= 0.02f;
            Maru.color = c; // 画像の不透明度を下げる
    
            if (c.a <= 0f) // 不透明度が0以下のとき
            {
                c.a = 0f;
                Maru.color = c; // 不透明度を0
                break; // 繰り返し終了
            }
        }        
        Maru.gameObject.SetActive(false); // 画像を非アクティブにする
    }
}
