using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NotuController : MonoBehaviour
{
    // 各種オブジェクトを定義
    public GameObject judgeArea;
    private Text judgeText_1;
    private Text judgeText_2;
    private Text judgeText_3;
    private Text judgeText_4;

    //スコア関連
    [SerializeField]
    private TextMeshProUGUI cardNameText;
    private int score;


    // ノーツに速度関連
    Rigidbody rb;
    private float velocityX = 0f;
    private float velocityY = 0f;
    [SerializeField] float Speed;

    // ノーツのx軸を指定
    float xpos_1 = -3.6f;
    float xpos_2 = -1.3f;
    float xpos_3 = 1.1f;
    float xpos_4 = 3.6f;

    // 判定ラインの数値(ノーツと判定ブロックの距離)
    [SerializeField] float BadPosition;
    [SerializeField] float GoodPosition;
    [SerializeField] float GreatPosition;
    [SerializeField] float ParfectPosition;

    //スタート、エンド関連
    //private Text GameOverText;
    //private bool isGameOver = false;


    // Start is called before the first frame update
    void Start()
    {
        // 各種オブジェクトの取得
        rb = GetComponent<Rigidbody>();
        judgeArea = GameObject.Find("JudgeArea");
        judgeText_1 = GameObject.Find("Judgetext(1)").GetComponent<Text>();
        judgeText_2 = GameObject.Find("Judgetext(2)").GetComponent<Text>();
        judgeText_3 = GameObject.Find("Judgetext(3)").GetComponent<Text>();
        judgeText_4 = GameObject.Find("Judgetext(4)").GetComponent<Text>();

        cardNameText.text = "SCORE " + score;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // ノーツに一定の速度を付与
        rb.velocity = new Vector3(velocityX, velocityY, Speed);

    }

    void Update()
    {
        
        // ノーツと判定エリアの
          float offsetZ = judgeArea.transform.position.z - this.transform.position.z;

        // 各キーの処理
        if (this.gameObject.transform.position.x == xpos_1)
        {

            if (Input.GetKeyDown(KeyCode.D))
            {

                if (offsetZ > BadPosition)
                {
                    judgeText_1.text = "Bad";
                    //scoreText.text = "SCORE " + score;
                    score += 10;
                    Destroy(this.gameObject);
                }

                if (offsetZ > GoodPosition)
                {
                    judgeText_1.text = "Good";
                    //scoreText.text = "SCORE " + score;
                    score += 10;
                    Destroy(this.gameObject);
                }

                if (offsetZ > GreatPosition)
                {
                    judgeText_1.text = "Great";
                    //scoreText.text = "SCORE " + score;
                    score += 10;
                    Destroy(this.gameObject);
                }

                if (offsetZ > ParfectPosition)
                {
                    judgeText_1.text = "Parfect";
                    //scoreText.text = "SCORE " + score;
                    score += 10;
                    Destroy(this.gameObject);
                }
            }
        }

        if (this.gameObject.transform.position.x == xpos_2)
        {
            if(Input.GetKeyDown(KeyCode.F))
            {
                if (offsetZ > BadPosition)
                {
                    judgeText_2.text = "Bad";
                    
                    Destroy(this.gameObject);
                }

                if (offsetZ > GoodPosition)
                {
                    judgeText_2.text = "Good";
                    
                    Destroy(this.gameObject);
                }

                if (offsetZ > GreatPosition)
                {
                    judgeText_2.text = "Great";
                    
                    Destroy(this.gameObject);
                }

                if (offsetZ > ParfectPosition)
                {
                    judgeText_2.text = "Parfect";
                    
                    Destroy(this.gameObject);
                }
            }
        }

        if(this.transform.position.x == xpos_3)
        {
            if (Input.GetKeyDown(KeyCode.J))
            {
                if (offsetZ > BadPosition)
                {
                    judgeText_3.text = "Bad";
                    
                    Destroy(this.gameObject);
                }

                if (offsetZ > GoodPosition)
                {
                    judgeText_3.text = "Good";
                    
                    Destroy(this.gameObject);
                }

                if (offsetZ > GreatPosition)
                {
                    judgeText_3.text = "Great";
                    
                    Destroy(this.gameObject);
                }

                if (offsetZ > ParfectPosition)
                {
                    judgeText_3.text = "Parfect";
                    
                    
                    Destroy(this.gameObject);
                }
            }
        }

        if(this.transform.position.x == xpos_4)
        {
            if(Input.GetKeyDown(KeyCode.K))
            {
                if (offsetZ > BadPosition)
                {
                    judgeText_4.text = "Bad";
                    
                    Destroy(this.gameObject);
                }

                if (offsetZ > GoodPosition)
                {
                    judgeText_4.text = "Good";
                   
                    Destroy(this.gameObject);
                }

                if (offsetZ > GreatPosition)
                {
                    judgeText_4.text = "Great";
                    
                    Destroy(this.gameObject);
                }

                if (offsetZ > ParfectPosition)
                {
                    judgeText_4.text = "Parfect";
                              
                    Destroy(this.gameObject);
                }
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "badArea")
        {
            if (this.transform.position.x == xpos_1)
            {
                judgeText_1.text = "Miss";
               
                
            }

            if (this.transform.position.x == xpos_2)
            {
                judgeText_2.text = "Miss";
                
                
            }

            if (this.transform.position.x == xpos_3)
            {
                judgeText_3.text = "Miss";
                
            }

            if (this.transform.position.x == xpos_4)
            {
                judgeText_4.text = "Miss";
                
            }
            
            Destroy(this.gameObject);
        }
    }
}
     