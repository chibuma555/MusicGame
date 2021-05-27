using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotuGenerator : MonoBehaviour
{
    // オブジェクトを入れる
    public GameObject notuPrefab;
    // ノーツ生成地点(開始）
    private int startPos = 100;
    //ノーツ生成地点(終了）
    private int goalPos = 360;
    //ノーツのx軸の範囲
    private float posRange = 2.5f;

    // Start is called before the first frame update
    void Start()
    {
        float offsetZ = 1f;
        GameObject notu;

        // ノーツの生成する量を決める
        for (int i = startPos; i < goalPos; i+=20)
        {
            //ノーツ1つ配置
            notu = Instantiate(notuPrefab);
            notu.transform.position = new Vector3();

            //　ノーツ4つ配置
            for (int j = -1; j <= 2; j++)
            { 
                notu = Instantiate(notuPrefab);
                notu.transform.position = new Vector3(posRange * j, notu.transform.position.y * -1.5f, offsetZ * i);
            }
            // ノーツが3つ配置
            for (int j = -1; j <= 1; j++)
            {

            }
            //　ノーツを２つ配置
            for (int j = -1; j <= 0; j++)
            {

            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
