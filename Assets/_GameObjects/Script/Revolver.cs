using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Revolver : MonoBehaviour
{

    [SerializeField] GameObject prefabBala;
    [SerializeField] Transform transformPuntoDeDisparo;
    [SerializeField] float fuerzaDisparo;
    int capacidadCargador = 6000;
    [SerializeField] Text txtNumeroBalas;
    
    public int numeroBalas;

    private void Start()
    {
        numeroBalas = capacidadCargador;
        txtNumeroBalas.text = numeroBalas.ToString();
        
    }

    public void Recargar(int numeroBalasCaja)
    {
        numeroBalas = Mathf.Min(numeroBalas + numeroBalasCaja,capacidadCargador);
        txtNumeroBalas.text = numeroBalas.ToString();
    }

    public void Disparar() {

        if (numeroBalas > 0)
        {

            numeroBalas--;

            txtNumeroBalas.text = numeroBalas.ToString();
            //Instanciar bala(prefab bala)
            GameObject bala = Instantiate(prefabBala);

            //Posicionar bala(punto de spawn)
            bala.transform.position = transformPuntoDeDisparo.transform.position;
            bala.transform.rotation = transformPuntoDeDisparo.transform.rotation;

            //Impulsar bala(rigidbody de la bala)
            bala.GetComponent<Rigidbody>().AddForce(transformPuntoDeDisparo.forward * fuerzaDisparo);

        }
       

        

    }
}
