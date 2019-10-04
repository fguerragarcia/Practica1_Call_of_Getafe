﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMobile : Enemy
{
    public float speed;
    public float tiempoEntreRotacion;
   

    public void Start()
    {
        
        InvokeRepeating("Rotar", tiempoEntreRotacion, tiempoEntreRotacion);
    }

    private void Update()
    {
        Mover();
    }

    public void Mover() {

        transform.Translate(Vector3.forward * Time.deltaTime * speed);

    }

    public void Rotar() {

        transform.Rotate(0, Random.Range(0, 180), 0);    
    }
}
