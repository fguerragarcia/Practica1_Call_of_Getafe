using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Headshot : EnemyListo
{
    private void Update()
    {
        base.Update();

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Proyectil"))
        {

            print("HEADSHOT");

            Destroy(gameObject);


        }
    }

}


