using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotuController : MonoBehaviour
{
    public Rigidbody rigidbody;
    private float velocityX = 0f;
    private float velocityY = 0f;
    private float velocityZ = -30f;
   
   
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //ノーツの移動
        rigidbody.velocity = new Vector3(velocityX, velocityY, velocityZ);
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("あたったぞ ！！！");
    }


}

