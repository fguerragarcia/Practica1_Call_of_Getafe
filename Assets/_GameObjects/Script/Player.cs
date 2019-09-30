using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] Revolver revolver;
   
    private void Update()
    {

        if (Input.GetMouseButtonDown(0)) {   

            Disparar();
        }

    } 
    public void Recargar(int numeroBalas) {

        revolver.Recargar(numeroBalas);
    }
    
    void Disparar() {

        print("Shoot");
        revolver.Disparar();    
    }
}
