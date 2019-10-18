using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmaSnipper : Arma
{

    [Header("Zoom")]
    [SerializeField] Camera camara;
    [SerializeField] Transform puntoDisparo;
    [SerializeField] GameObject reticulaNormal;
    [SerializeField] GameObject reticulaSnipper;
    [SerializeField] GameObject crucetaSniper;

    [SerializeField] GameObject prefabMarca;

    [SerializeField] int danyo;

   

    private void Update()
    {
        //base.Update();
        if (Input.GetMouseButtonDown(1)) {
            
            camara.fieldOfView = 10;
             //modifico el Field of View 
            print("Zoom");
            reticulaNormal.SetActive(false);
            reticulaSnipper.SetActive(true);
            crucetaSniper.SetActive(false);

        } else if (Input.GetMouseButtonUp(1)){

            camara.fieldOfView = 60;
            reticulaSnipper.SetActive(false);
            crucetaSniper.SetActive(true);
        }
    }

    public override void Disparar()
    {
        RaycastHit rch;
        /*bool hayImpacto = Physics.Raycast(
            puntoDisparo.position,
            puntoDisparo.forward,
            out rch);*/

        Ray rayito = new Ray(puntoDisparo.position, puntoDisparo.forward);

        bool hayImpacto = Physics.Raycast(rayito, out rch);
        Debug.DrawRay(puntoDisparo.position, puntoDisparo.forward * rch.distance, Color.red, 10);

        if (hayImpacto)
        {
            if (rch.collider.gameObject.CompareTag("Enemy"))
            {

                print("DAÑO");

                rch.collider.gameObject.GetComponent<Enemy>().RecibirDanyo(danyo);
                
            }

            print(rch.collider.gameObject.name);

            //GameObject impacto = Instantiate(prefabMarca, rch.point, Quaternion.identity);

            GameObject impacto = Instantiate(prefabMarca, rch.transform);
            impacto.transform.position = rch.point;
            impacto.transform.rotation = Quaternion.FromToRotation(Vector3.back, rch.normal);
            impacto.transform.Translate(Vector3.back * 0.01f);
            //Debug.DrawRay(rch.point, rch.normal, Color.blue, 10);
        }
    }
    
}
