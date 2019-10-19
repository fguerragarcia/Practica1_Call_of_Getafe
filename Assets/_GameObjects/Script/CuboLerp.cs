using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboLerp : MonoBehaviour
{
    float t = 0f;

    public float speed;
    
    public Transform p1 , p2;

    void Update()
    {
        t = t + Time.deltaTime;
        transform.position = Vector3.Lerp(p1.position, p2.position, t* speed);
    }
}
