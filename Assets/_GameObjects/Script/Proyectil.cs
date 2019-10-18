using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour
{
    [SerializeField] int danyo;

    private void Start()
    {
        Destroy(gameObject, 3);
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Enemy")) {

            print("DAÑO");

            collision.gameObject.GetComponent<Enemy>().RecibirDanyo(danyo);
            Destroy(gameObject);
        }

       
    }

}
