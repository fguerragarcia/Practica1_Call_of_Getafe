using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] GameObject Targets;
    [SerializeField] GameObject TargetDisparador;
    [SerializeField] int speed;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Proyectil")) {

            print("HIT");

            Targets.transform.Rotate(Vector3.right * Time.deltaTime * speed);

        }
    }

}