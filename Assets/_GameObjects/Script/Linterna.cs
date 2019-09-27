using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Linterna : MonoBehaviour
{
    [SerializeField] GameObject Linterna;

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)) {
            Linterna.SetActive(!Linterna.activeSelf);
        }
    }
}
