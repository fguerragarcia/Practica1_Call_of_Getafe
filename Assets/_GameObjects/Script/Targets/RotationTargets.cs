using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationTargets : MonoBehaviour
{
    public int speed = 5;
    public int tiempoCambioDireccion;
    

    public void Start()
    {
        InvokeRepeating("CambiarDireccion", tiempoCambioDireccion, tiempoCambioDireccion);
        
    }

    void Update()
    {
        Mover();
    }

    public void Mover() {
        transform.Translate(Vector3.right * Time.deltaTime * speed);

    }

    public void CambiarDireccion() {

        if (speed == 5)
        {
            speed = -5;
        }
        else 
        {
            speed = 5;
        }

    }
}
