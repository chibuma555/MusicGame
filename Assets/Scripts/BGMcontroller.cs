using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMcontroller : MonoBehaviour
{
    public AudioClip sorce1;
    AudioSource audiosource;
    float count;
    bool t;
    

    // Start is called before the first frame update
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
        t = true;
    }

    // Update is called once per frame
    void Update()
    {
        count += Time.deltaTime;
        Debug.Log("経過時間(秒)" + Time.time);

        float audiotime = audiosource.time;
        if (count >= 3 && t == true)
        {
            t = false;
            count = 0;
            audiosource.Play();
            Debug.Log("五秒");
        }
   
    }
}
