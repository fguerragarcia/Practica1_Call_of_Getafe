
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerArea : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    [SerializeField] float delay;
    [SerializeField] int limit;
    private int numeroInstancias;
    SpawnerArea spawnerArea;


    void Start()
    {
        InvokeRepeating("Spawnear", 0, delay);
    }

    void Spawnear()
    {
        Instantiate(prefab, transform.position, transform.rotation);
        numeroInstancias++;//Es lo mismo que numeroInstancias=numeroInstancias+1;
        if (numeroInstancias == limit)
        {
            CancelInvoke();
        }
    }
}