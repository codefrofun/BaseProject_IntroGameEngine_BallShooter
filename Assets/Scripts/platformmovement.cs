using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformmovement : MonoBehaviour
{
    public float speed = 0.1f;
    Vector3 pointA;
    Vector3 pointB;

    void Start()
    {
        pointA = new Vector3(2, -2, -20);
        pointB = new Vector3(2, -2, -24);
    }

    void Update()
    {
        //PingPong between 0 and 1
        float time = Mathf.PingPong(Time.time * speed * 0.5f, 1);
        transform.position = Vector3.Lerp(pointA, pointB, time);
    }
}
