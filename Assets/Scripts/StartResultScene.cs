using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartResultScene : MonoBehaviour
{
    GameObject result;
    GameObject judgeText_1;
    GameObject judgeText_2;
    GameObject judgeText_3;
    GameObject judgeText_4;
    float totalTime = 65;
    int retime;

    // Start is called before the first frame update
    void Start()
    {
        result = GameObject.Find("ResultStage");
        result.SetActive(false);

        judgeText_1 = GameObject.Find("Judgetext(1)");
        judgeText_2 = GameObject.Find("Judgetext(2)");
        judgeText_3 = GameObject.Find("Judgetext(3)");
        judgeText_4 = GameObject.Find("Judgetext(4)");
        judgeText_1.SetActive(true);
        judgeText_2.SetActive(true);
        judgeText_3.SetActive(true);
        judgeText_4.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        totalTime -= Time.deltaTime;
        retime = (int)totalTime;
        //timeTexts.text = retime.ToString();
        //Debug.Log(Time.time);
        if(retime == 0)
        {
            result.SetActive(true);
            judgeText_1.SetActive(false);
            judgeText_2.SetActive(false);
            judgeText_3.SetActive(false);
            judgeText_4.SetActive(false);
        }
    }
}
