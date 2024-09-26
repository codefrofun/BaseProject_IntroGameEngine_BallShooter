using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeFall : MonoBehaviour
{
    public float fallSpeed = 8.0f;
    private Rigidbody rb;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    { 
        transform.Translate(Vector3.down * fallSpeed * Time.deltaTime, Space.World);

    }
}
