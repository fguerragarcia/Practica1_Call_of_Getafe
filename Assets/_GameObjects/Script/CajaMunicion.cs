using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaMunicion : MonoBehaviour
{
    [SerializeField] int numeroBalasCaja;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Player")
        {
            print("CHOQUE");

            other.gameObject.GetComponent<Player>().Recargar(numeroBalasCaja);

            Destroy(gameObject);

        }
    }
    
}
