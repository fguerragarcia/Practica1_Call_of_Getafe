using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmaProyectil : Arma
{
    [SerializeField] GameObject prefabHumo;
    [SerializeField] GameObject prefabBala;
    [SerializeField] Transform puntoDisparo;
    [SerializeField] float fuerza;

    public override void Disparar()
    {
        GameObject proyectil = Instantiate(prefabBala, puntoDisparo.position, puntoDisparo.rotation);
        proyectil.GetComponent<Rigidbody>().AddForce(puntoDisparo.forward * fuerza);

        GameObject humo = Instantiate(prefabHumo, puntoDisparo.position, puntoDisparo.rotation);

    }

   
}
