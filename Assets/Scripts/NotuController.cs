using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NotuController : MonoBehaviour
{
    // 各種オブジェクトを定義
    public GameObject judgeArea;
    private Text judgeText_1;
    private Text judgeText_2;
    private Text judgeText_3;
    private Text judgeText_4;
    private ScoreManager sm;    

    // ノーツに速度関連
    Rigidbody rb;
    private float velocityX = 0f;
    private float velocityY = 0f;
    private float velocityZ = -13f;

    // ノーツのx軸を指定
    float xpos_1 = -3.9f;
    float xpos_2 = -1.25f;
    float xpos_3 = 1.31f;
    float xpos_4 = 3.9f;

    // 判定ラインの数値(ノーツと判定ブロックの距離)
    [SerializeField] float BadPosition;
    [SerializeField] float GoodPosition;
    [SerializeField] float GreatPosition;
    [SerializeField] float ParfectPosition;

    // 子要素を管理するリスト
    List<GameObject> myParts = new List<GameObject>();

    // BGM関連
    AudioSource sound;
    public AudioClip Clip;

    bool clash = false;


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
        sm = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        sound = GetComponent<AudioSource>();

        
        


        // 自分の子要素をチェック(ブロックの破片を子要素に)
        foreach (Transform child in gameObject.transform)
        {
            // ノーツにRigidbodyを追加してKinematicにしておく
            child.gameObject.AddComponent<Rigidbody>();
            child.gameObject.GetComponent<Rigidbody>().isKinematic = true;

            // 子要素リストにパーツの追加
            myParts.Add(child.gameObject);
        }

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // ノーツに一定の速度を付与
        rb.velocity = new Vector3(velocityX, velocityY, velocityZ);
    }

    void Update()
    { 
        // ノーツと判定エリアの距離
        float offsetZ = judgeArea.transform.position.z - this.transform.position.z;
        
        // 各キーの処理
        if (this.gameObject.transform.position.x == xpos_1)
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                if (offsetZ > ParfectPosition)
                {
                    
                    judgeText_1.text = "Parfect";
                    sm.AddScore(500, true);
                    sm.AddCombo(count:1);
                    sound.PlayOneShot(Clip);
                    Explode();

                }
                else if (offsetZ > GreatPosition)
                {
                    
                    judgeText_1.text = "Great";
                    sm.AddScore(300, true);
                    sm.AddCombo(count: 1);
                    sound.PlayOneShot(Clip);
                    Explode();

                }
                else if (offsetZ > GoodPosition)
                {
                    
                    judgeText_1.text = "Good";
                    sm.AddScore(100, true);
                    sm.AddCombo(count: 1);
                    sound.PlayOneShot(Clip);
                    Explode();

                }
                else if (offsetZ > BadPosition)
                {
                    
                    judgeText_1.text = "Bad";
                    sm.ComboReset();
                    sound.PlayOneShot(Clip);
                    Explode();

                }
            }
        }

        if (this.gameObject.transform.position.x == xpos_2)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                if (offsetZ > ParfectPosition)
                {
                    judgeText_2.text = "Parfect";
                    sm.AddScore(500, true);
                    sm.AddCombo(count: 1);
                    sound.PlayOneShot(Clip);
                    Explode();
                }
                else if (offsetZ > GreatPosition)
                {
                    judgeText_2.text = "Great";
                    sm.AddScore(300, true);
                    sm.AddCombo(count: 1);
                    sound.PlayOneShot(Clip);
                    Explode();
                }
                else if (offsetZ > GoodPosition)
                {
                    judgeText_2.text = "Good";
                    sm.AddScore(100, true);
                    sm.AddCombo(count: 1);
                    sound.PlayOneShot(Clip);
                    Explode();
                }
                else if (offsetZ > BadPosition)
                {
                    judgeText_2.text = "Bad";
                    sm.ComboReset();
                    sound.PlayOneShot(Clip);
                    Explode();
                }
            }
        }

        if (this.transform.position.x == xpos_3)
        {
            if (Input.GetKeyDown(KeyCode.J))
            {
                if (offsetZ > ParfectPosition)
                {
                    judgeText_3.text = "Parfect";
                    sm.AddScore(500, true);
                    sm.AddCombo(count: 1);
                    sound.PlayOneShot(Clip);
                    Explode();
                }
                else if (offsetZ > GreatPosition)
                {
                    judgeText_3.text = "Great";
                    sm.AddScore(300, true);
                    sm.AddCombo(count: 1);
                    sound.PlayOneShot(Clip);
                    Explode();
                }
                else if (offsetZ > GoodPosition)
                {
                    judgeText_3.text = "Good";
                    sm.AddScore(100, true);
                    sm.AddCombo(count: 1);
                    sound.PlayOneShot(Clip);
                    Explode();
                }
                else if (offsetZ > BadPosition)
                {
                    judgeText_3.text = "Bad";
                    sm.ComboReset();
                    sound.PlayOneShot(Clip);
                    Explode();
                }
            }
        }

        if (this.transform.position.x == xpos_4)
        {
            if (Input.GetKeyDown(KeyCode.K))
            {
                if (offsetZ > ParfectPosition)
                {
                    judgeText_4.text = "Parfect";
                    sm.AddScore(500, true);
                    sm.AddCombo(count: 1);
                    sound.PlayOneShot(Clip);
                    Explode();
                }
                else if (offsetZ > GreatPosition)
                {
                    judgeText_4.text = "Great";
                    sm.AddScore(300, true);
                    sm.AddCombo(count: 1);
                    sound.PlayOneShot(Clip);
                    Explode();
                }
                else if (offsetZ > GoodPosition)
                {
                    judgeText_4.text = "Good";
                    sm.AddScore(100, true);
                    sm.AddCombo(count: 1);
                    sound.PlayOneShot(Clip);
                    Explode();
                }
                else if (offsetZ > BadPosition)
                {
                    judgeText_4.text = "Bad";
                    sm.ComboReset();
                    sound.PlayOneShot(Clip);
                    Explode();
                }
            }
        }
    }

   


    // ノーツエフェクト
    void Explode()
    {  
        foreach (GameObject obj in myParts)
        {
            var random = new System.Random();
            var min = -3;
            var max = 3;

            //　飛ぶパワーと回転をランダムに設定
            Vector3 forcePower = new Vector3(random.Next(min, max), random.Next(0, max), random.Next(min, max));
            obj.GetComponent<Rigidbody>().isKinematic = false;
            obj.GetComponent<Rigidbody>().AddForce(forcePower, ForceMode.Impulse);
            obj.GetComponent<Rigidbody>().AddTorque(forcePower, ForceMode.Impulse);
            Invoke("Destroynotu", 0.5f);
        }
        clash = true;
    }
    
    void Destroynotu()
    {
        Destroy(this.gameObject);
    }
        

    //衝突判定(miss時のみ)
    void OnTriggerEnter(Collider other)
    {
         if (other.gameObject.tag == "badArea")
         {
            if (this.transform.position.x == xpos_1)
            {
                judgeText_1.text = "Miss";
                sm.ComboReset();
            }

            if (this.transform.position.x == xpos_2)
            {
                judgeText_2.text = "Miss";
                sm.ComboReset();
            }

            if (this.transform.position.x == xpos_3)
            {
                judgeText_3.text = "Miss";
                sm.ComboReset();
            }

            if (this.transform.position.x == xpos_4)
            {
                judgeText_4.text = "Miss";
                sm.ComboReset();
            }

            Destroy(this.gameObject);
         }
    }

    
}
    
     