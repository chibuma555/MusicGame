using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotalScore : MonoBehaviour
{
    //　各種オブジェクト定義
    public Text resultText;
    public Text resultrank;
    public ScoreManager scoremanajer;

    //スコア数値
    int totalscore;

    // Start is called before the first frame update
    void Start()
    {
        //オブジェクト取得
        resultText = GameObject.Find("TotalScore").GetComponent<Text>();
        resultrank = GameObject.Find("RankScore").GetComponent<Text>();
        scoremanajer = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();

        //Getscoreを代入
        totalscore = scoremanajer.GetScore();

        //テキストの表示
        resultText.text = totalscore.ToString();

        //Debug.Log(scoremanajer.GetScore());

        //スコアによってランク(Sランク~Dランク)
        if (totalscore < 3000)
        {
            resultrank.text = "D";
        }
        else if(totalscore > 3000 && totalscore < 10000)
        {
            resultrank.text = "C";
        }
        else if(totalscore > 10000 && totalscore < 40000)
        {
            resultrank.text = "B";
        }
        else if(totalscore > 40000 && totalscore < 50000)
        {
            resultrank.text = "A";
        }
        else if(totalscore > 50000)
        {
            resultrank.text = "S";
        }
    }
}
