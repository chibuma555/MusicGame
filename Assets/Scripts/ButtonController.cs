using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public Material myColor;
    public float speed = 10f;
    GameObject cube1;
    GameObject cube2;
    GameObject cube3;
    GameObject cube4;

    // Start is called before the first frame update
    void Start()
    {
        cube1 = GameObject.Find("Selectber");
        cube2 = GameObject.Find("Selectber(1)");
        cube3 = GameObject.Find("Selectber(2)");
        cube4 = GameObject.Find("Selectber(3)");

    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKeyDown(KeyCode.A))
      {
            // cubeの位置 = 現在の位置から指定した位置へLerpの補間分だけ毎秒移動。
            transform.position = Vector3.Lerp(transform.position, new Vector3(6, 0.3f, -5), Time.deltaTime * 1);
            // cubeの大きさ = 現在の大きさから指定した大きさへLerpの補間分だけ毎秒大きく。
            transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(60, 1, 8), Time.deltaTime * 1);
            GetComponent<Renderer>().material = myColor;
      }
    }

}
