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
    float xpos_2 = -1.23f;
    float xpos_3 = 1.23f;
    float xpos_4 = 3.7f;

    float ypos = 0.3f;


    // Start is called before the first frame update
    void Start()
    {
        for (int i =0; i <= 50; i++)
        {
            GameObject notu = Instantiate(NotuPrefab);
            ListValue.Add(notu);
        }

        ListValue[0].transform.position = new Vector3(xpos_1, ypos, 5f);
        ListValue[1].transform.position = new Vector3(xpos_1, ypos, 10f);
        
        ListValue[2].transform.position = new Vector3(xpos_1, ypos, 20f);
        ListValue[3].transform.position = new Vector3(xpos_1, ypos, 30f);

        ListValue[4].transform.position = new Vector3(xpos_1, ypos, 40f);
        ListValue[5].transform.position = new Vector3(xpos_1, ypos, 50f);
        ListValue[6].transform.position = new Vector3(xpos_1, ypos, 60f);
        ListValue[7].transform.position = new Vector3(xpos_1, ypos, 70f);
        ListValue[8].transform.position = new Vector3(xpos_1, ypos, 80f);
        ListValue[9].transform.position = new Vector3(xpos_2, ypos, 90f);
        ListValue[10].transform.position = new Vector3(xpos_1, ypos, 100f);
        ListValue[11].transform.position = new Vector3(xpos_3, ypos, 250f);

        ListValue[12].transform.position = new Vector3(xpos_2, ypos, 270f);
        ListValue[13].transform.position = new Vector3(xpos_3, ypos, 270f);

        ListValue[14].transform.position = new Vector3(xpos_1, ypos, 290f);
        ListValue[15].transform.position = new Vector3(xpos_2, ypos, 300f);
        ListValue[16].transform.position = new Vector3(xpos_1, ypos, 310f);

        ListValue[17].transform.position = new Vector3(xpos_2, ypos, 330f);
        ListValue[18].transform.position = new Vector3(xpos_4, ypos, 350f);
        ListValue[19].transform.position = new Vector3(xpos_3, ypos, 360f);

        ListValue[20].transform.position = new Vector3(xpos_1, ypos, 380f);
        ListValue[21].transform.position = new Vector3(xpos_4, ypos, 380f);

        ListValue[22].transform.position = new Vector3(xpos_2, ypos, 390f);
        ListValue[23].transform.position = new Vector3(xpos_3, ypos, 390f);

        ListValue[24].transform.position = new Vector3(xpos_4, ypos, 400f);
        ListValue[25].transform.position = new Vector3(xpos_1, ypos, 400f);
        ListValue[26].transform.position = new Vector3(xpos_2, ypos, 410f);
        ListValue[27].transform.position = new Vector3(xpos_1, ypos, 420f);
        ListValue[28].transform.position = new Vector3(xpos_2, ypos, 440f);

        ListValue[29].transform.position = new Vector3(xpos_1, ypos, 470f);
        ListValue[30].transform.position = new Vector3(xpos_4, ypos, 470f);

        ListValue[31].transform.position = new Vector3(xpos_2, ypos, 380f);
        ListValue[32].transform.position = new Vector3(xpos_1, ypos, 480f);

        ListValue[33].transform.position = new Vector3(xpos_1, ypos, 490f);
        ListValue[34].transform.position = new Vector3(xpos_3, ypos, 500f);

        ListValue[35].transform.position = new Vector3(xpos_3, ypos, 520f);
        ListValue[36].transform.position = new Vector3(xpos_3, ypos, 540f);
        ListValue[37].transform.position = new Vector3(xpos_2, ypos, 560f);
        ListValue[38].transform.position = new Vector3(xpos_1, ypos, 570f);
        ListValue[39].transform.position = new Vector3(xpos_2, ypos, 580f);

        ListValue[40].transform.position = new Vector3(xpos_3, ypos, 590f);
        ListValue[41].transform.position = new Vector3(xpos_4, ypos, 590f);

        ListValue[42].transform.position = new Vector3(xpos_2, ypos, 600f);
        ListValue[43].transform.position = new Vector3(xpos_4, ypos, 610f);

        ListValue[44].transform.position = new Vector3(xpos_3, ypos, 620f);
        ListValue[45].transform.position = new Vector3(xpos_1, ypos, 620f);

        ListValue[46].transform.position = new Vector3(xpos_1, ypos, 630f);
        ListValue[47].transform.position = new Vector3(xpos_2, ypos, 630f);

        ListValue[48].transform.position = new Vector3(xpos_2, ypos, 640f);
        ListValue[49].transform.position = new Vector3(xpos_4, ypos, 650f);
        ListValue[50].transform.position = new Vector3(xpos_3, ypos, 660f);

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
