using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Revolver : MonoBehaviour
{

    [SerializeField] GameObject prefabBala;
    [SerializeField] Transform transformPuntoDeDisparo;
    [SerializeField] float fuerzaDisparo;

    
    public void Disparar() {

        //Instanciar bala(prefab bala)
        GameObject bala = Instantiate(prefabBala);

        //Posicionar bala(punto de spawn)
        bala.transform.position = transformPuntoDeDisparo.transform.position;
        bala.transform.rotation = transformPuntoDeDisparo.transform.rotation;

        //Impulsar bala(rigidbody de la bala)
        bala.GetComponent<Rigidbody>().AddRelativeForce(0, 0, fuerzaDisparo);

    }
}
