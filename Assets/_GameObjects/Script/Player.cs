using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] Arma[] armas;
    

    private void Start()
    {
        
    }

    private void Update()
    {

        if (Input.GetMouseButtonDown(0)) {

            ApretarGatillo();
        }
        


    } 
    
    
    void ApretarGatillo() {

        IntentarDisparar();

        print("Shoot");
        //revolver.Disparar();
        

    }

   

    void ActivarArma(int numeroArma) {

        if (numeroArma != armaActiva) {

            armas[armaActiva].gameObject.SetActive(false);
            armaActiva = numeroArma;
            armas[armaActiva].gameObject.SetActive(true);
            
        }
        
    }
}
