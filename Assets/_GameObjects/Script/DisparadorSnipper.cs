using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparadorSnipper : MonoBehaviour
{
    [SerializeField] Transform puntoDisparo;
    [SerializeField] GameObject prefabMarca;
    [SerializeField] float fuerza;
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Fire();
        }
    }

    private void Fire()
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
