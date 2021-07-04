using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextAnimation : MonoBehaviour
{
    //テキスト　アニメーション
    [SerializeField] Animator textAnime;

    // Start is called before the first frame update
    void Start()
    {
        //アニメーション
        textAnime = GameObject.Find("Judgetext(1)").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            textAnime.SetBool("is_drow", true);
        }
        else　if(Input.GetKeyUp(KeyCode.D))
        {
            textAnime.SetBool("is_drow", false);
        }
        
           
    }
}
