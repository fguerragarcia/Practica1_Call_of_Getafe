using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmaLanzagranadas : Arma
{
    [SerializeField] GameObject prefabBala;
    [SerializeField] Transform puntoDisparo;
    [SerializeField] float fuerza;
    
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            IntentarDisparar();
        }
    }
    
    public override void Disparar()
    {
        
        GameObject proyectil = Instantiate(
            prefabBala,
            puntoDisparo.transform.position,
            puntoDisparo.transform.rotation);
        proyectil.GetComponent<Rigidbody>().AddForce(puntoDisparo.forward * fuerza);
    }
}
