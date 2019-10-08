using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmaSnipper : Arma
{

    [Header("Zoom")]
    [SerializeField] Camera camara;

    private void Update()
    {
        //base.Update();
        if (Input.GetMouseButtonDown(1)) {

            camara.fieldOfView = 10;
            print("Zoom");
            //modifico el Field of View 

        } else if (Input.GetMouseButtonUp(1)){

            camara.fieldOfView = 60;
        }
    }

    public override void Disparar()
    {

    }

}
