using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowTarget : MonoBehaviour
{
    private int speed = 60;
    public float tiempoCambioDireccion;


    public void Start()
    {
        InvokeRepeating("CambiarDireccion", tiempoCambioDireccion, tiempoCambioDireccion);

    }

    void Update()
    {
        Mover();
    }

    public void Mover()
    {
        transform.Rotate(Vector3.right * Time.deltaTime * speed);

    }

    public void CambiarDireccion()
    {

        if (speed == speed)
        {
            speed = -speed;
        }
        else
        {
            speed = speed;
        }

    }
}
