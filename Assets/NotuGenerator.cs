using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotuGenerator : MonoBehaviour
{

    //オブジェクトを定義
    public GameObject NotuPrefab;
    //リストを定義
    List<GameObject> ListValue = new List<GameObject>();

    float xpos_1 = -3.7f;
    float xpos_2 = -1.3f;
    float xpos_3 = 1.2f;
    float xpos_4 = 3.6f;

    float ypos = 0.65f;


    // Start is called before the first frame update
    void Start()
    {
        

        for (int i =0; i <= 30; i++)
        {
            GameObject notu = Instantiate(NotuPrefab);
            ListValue.Add(notu);
        }

        ListValue[0].transform.position = new Vector3(xpos_1, ypos, 130f);
        ListValue[1].transform.position = new Vector3(xpos_4, ypos, 130f);
        
        ListValue[2].transform.position = new Vector3(xpos_1, ypos, 200f);
        ListValue[3].transform.position = new Vector3(xpos_4, ypos, 200f);

        ListValue[4].transform.position = new Vector3(xpos_1, ypos, 250f);
        ListValue[5].transform.position = new Vector3(xpos_4, ypos, 300f);
        ListValue[6].transform.position = new Vector3(xpos_4, ypos, 350f);
        ListValue[7].transform.position = new Vector3(xpos_3, ypos, 400f);
        ListValue[8].transform.position = new Vector3(xpos_1, ypos, 500f);
        ListValue[9].transform.position = new Vector3(xpos_2, ypos, 550f);
        ListValue[10].transform.position = new Vector3(xpos_1, ypos, 600f);
        ListValue[11].transform.position = new Vector3(xpos_3, ypos, 600f);

        ListValue[12].transform.position = new Vector3(xpos_2, ypos, 650f);
        ListValue[13].transform.position = new Vector3(xpos_3, ypos, 650f);

        ListValue[14].transform.position = new Vector3(xpos_1, ypos, 700f);
        ListValue[15].transform.position = new Vector3(xpos_2, ypos, 710f);
        ListValue[16].transform.position = new Vector3(xpos_1, ypos, 720f);

        ListValue[17].transform.position = new Vector3(xpos_2, ypos, 750f);
        ListValue[18].transform.position = new Vector3(xpos_4, ypos, 750f);
        ListValue[19].transform.position = new Vector3(xpos_3, ypos, 770f);

        ListValue[20].transform.position = new Vector3(xpos_1, ypos, 800f);
        ListValue[21].transform.position = new Vector3(xpos_4, ypos, 800f);

        ListValue[22].transform.position = new Vector3(xpos_2, ypos, 850f);
        ListValue[23].transform.position = new Vector3(xpos_3, ypos, 850f);

        ListValue[24].transform.position = new Vector3(xpos_4, ypos, 900f);
        ListValue[25].transform.position = new Vector3(xpos_1, ypos, 930f);
        ListValue[26].transform.position = new Vector3(xpos_2, ypos, 950f);
        ListValue[27].transform.position = new Vector3(xpos_1, ypos, 980f);
        ListValue[28].transform.position = new Vector3(xpos_2, ypos, 990f);

        ListValue[29].transform.position = new Vector3(xpos_1, ypos, 1200f);
        ListValue[30].transform.position = new Vector3(xpos_4, ypos, 1200f);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
