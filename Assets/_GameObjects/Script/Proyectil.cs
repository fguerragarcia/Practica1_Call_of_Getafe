using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour
{
    [SerializeField] int danyo;
    public GameObject prefabHit;

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Enemy")) {

            print("DAÑO");

            collision.gameObject.GetComponent<Enemy>().RecibirDanyo(danyo);
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("Target"))
        {
            Instantiate(prefabHit, transform.position, transform.rotation);

        }
    }

}
