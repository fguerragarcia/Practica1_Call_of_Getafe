using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cohete : MonoBehaviour
{
    [SerializeField] float retardo;
    [SerializeField] float radio;
    [SerializeField] float fuerzaExplosion;
    [SerializeField] float salto;
    [SerializeField] LayerMask capa;
    [SerializeField] GameObject explosionCohete;

    private void Start()
    {
        Invoke("Explotar", retardo);
        
        Destroy(gameObject, 3);
    } 
    private void Explotar()
    {
        Collider[] cols = Physics.OverlapSphere(transform.position, radio, capa.value);
        foreach (Collider c in cols)
        {
            if (c.gameObject.GetComponent<Rigidbody>() != null)
            {
                Instantiate(explosionCohete, this.transform.position, transform.rotation);

                c.gameObject.GetComponent<Rigidbody>().AddExplosionForce(
                    fuerzaExplosion,
                    transform.position,
                    radio,
                    salto);
                
            }
        }
    }
}
