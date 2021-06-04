using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NotuController : MonoBehaviour
{

    private float velocityX = 0f;
    private float velocityY = 0f;
    private float velocityZ = -30f;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity =  new Vector3(velocityX,velocityY, velocityZ);
    }

}

