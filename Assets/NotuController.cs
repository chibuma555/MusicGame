using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotuController : MonoBehaviour
{
    Rigidbody myRigidvody;
    private float velocityX = 0f;
    private float velocityY = 0.3f;
    private float velocityZ = -15f;

    // Start is called before the first frame update
    void Start()
    {
        myRigidvody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    void FixedUpdate()
    {
        myRigidvody.velocity = new Vector3(velocityX, velocityY, velocityZ);
    }
}

