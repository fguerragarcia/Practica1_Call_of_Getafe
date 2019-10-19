using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSpawner : MonoBehaviour
{
    [SerializeField] GameObject SpawnEnemigos;

    private void OnTriggerEnter(Collider other)
    {
        SpawnEnemigos.SetActive(true);
    }
}
