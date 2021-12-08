using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class action2 : MonoBehaviour
{
    public Sprite komatta;
    public Sprite normal;
    public Sprite egao;
    public Image man;
    int face = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)){
            face++;
            if(face > 2){
                face = 0;
            }
        }
        Change(face);

    }

    void Change(int a){
        switch (a){
                case 0:
                    man.sprite = komatta;
                    break;
                case 1:
                    man.sprite = normal;
                    break;
                case 2:
                    man.sprite = egao;
                    break;
            }

    }
}