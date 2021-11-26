using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class action : MonoBehaviour{

Image buttonImage_;
int imageId = 0; // 現在何を表示しているのか

// inspectorで直接画像のスプライトを張り付ける
public Sprite Asprite;
public Sprite Bsprite;
public Sprite Csprite;

void Start(){
	// コンポーネントからImageを取得
	buttonImage_ = GetComponent<Image>();
}

void Update(){
	// スペースキーが押された場合
	if (Input.GetKeyDown(KeyCode.Space)){
		// imageIdを更新
            	imageId++;
            	if (imageId > 2)
           	 {
            	   	 imageId = 0;
            	}
            // imageIdに合わせて表示
            switch (imageId)
            {
                case 0:
                    buttonImage_.sprite = Asprite;
                    break;
                case 1:
                    buttonImage_.sprite = Bsprite;
                    break;
                case 2:
                    buttonImage_.sprite = Csprite;
                    break;
            }
        }
    }
}
