using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotuController : MonoBehaviour
{

    private float velocityX = 0f;
    private float velocityY = 0f;
    private float velocityZ = -1f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(velocityX, velocityY, velocityZ);
    }
}

