using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] Revolver revolver;
   
   
    void Update()
    {

        if (Input.GetMouseButtonDown(0)) {

            Disparar();
        }

    }

    void Disparar() {

        print("Shoot");
        revolver.Disparar();    
    }
}
