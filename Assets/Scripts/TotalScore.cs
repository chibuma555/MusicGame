using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotalScore : MonoBehaviour
{
    public Text scoreText;
    int score;

    int ParfectCount;
    int GreatCount;
    int GoodCount;
    int BadCount;

    public Text countText;

    // Start is called before the first frame update
    void Start()
    {
        score = ScoreManager.getscore();
        scoreText.text = "SCORE" + score;
    }

    // Update is called once per frame
    void Update()
    {
        //if( == 500)
        //{
            //ParfectCount++;
            //countText.text = "" + ParfectCount;
        //}
    }
}
