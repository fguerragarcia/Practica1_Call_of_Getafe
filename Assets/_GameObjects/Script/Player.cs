using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] Arma[] armas;

    [SerializeField] int armaActiva = 0;

    private void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            ApretarGatillo();
        }

        //Recarga
        if (Input.GetKeyDown(KeyCode.R))
        {
            Recargar();
        }


        //Gestion de armas
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ActivarArma(0);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ActivarArma(1);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            ActivarArma(2);
        }
        else if (Input.GetKeyDown("4"))
        {
            ActivarArma(3);
        }
        
    }

    

    void ActivarArma(int numeroArma) {

        if (numeroArma >= armas.Length) {
            return;
        }

        if (numeroArma != armaActiva) {

            armas[armaActiva].gameObject.SetActive(false);
            armaActiva = numeroArma;
            armas[armaActiva].gameObject.SetActive(true);
            
        }
        
    }

    public void Recargar()
    {
        armas[armaActiva].Recargar();
    }

    void ApretarGatillo()
    {

        armas[armaActiva].IntentarDisparar();

        print("Gatillo");



    }
}
