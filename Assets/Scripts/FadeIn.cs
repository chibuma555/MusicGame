using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour
{
    Text text;
    private float time;
    public float fadetime;
    private bool flag = true;
    Text judgeText_1;

    // Start is called before the first frame update
    void Start()
    {
        fadetime = text.color.a;
        judgeText_1 = GameObject.Find("Judgetext(1)").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if(fadetime > 0)
        fadetime -= 0.05f;
        text.color = new Color(0, 0, 0, fadetime);
    }
}
