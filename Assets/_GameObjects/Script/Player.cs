using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] Revolver revolver;
   
   
    void Update()
    {

        if (Input.GetMouseButton(0)) {

            Disparar();
        }

    }

    private void Disparar() {

        print("Shoot");
        revolver.Disparar();    
    }
}
