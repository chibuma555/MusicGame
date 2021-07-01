using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    //スコア関連
    [SerializeField] Text scoreText;
    public static int score;

    //コンボ関連
    [SerializeField] Text comboText;
    private int combo;

    public static int getscore()
    {
        return score;
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "SCORE " + score;
    }

        // Update is called once per frame
     void Update()
     {

     }

    // スコア処理
    public void AddScore(int value, bool pulus)
    {
        comboText.enabled = true;
        if (pulus == true)
        {
            score += value;
        }
        else if (pulus == false)
        {

        }
        scoreText.text = "SCORE " + score;
    }

    // コンボ処理
    public void AddCombo(int count)
    {
        comboText.enabled = true;
        combo += count;
        comboText.text = "" + combo;
        if (combo > 1 && combo % 10 == 0)
        {
            score += 1000;
        }
    }

    // リセット処理(コンボ）
    public void ComboReset()
    {
        combo = 0;
        comboText.enabled = false;
    }

}