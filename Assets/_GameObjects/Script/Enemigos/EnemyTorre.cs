using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTorre : Enemy
{
    private float distanceToPlayer;
    [SerializeField] float attackDistance;
    [SerializeField] float speed;

    [SerializeField] GameObject prefabBala;
    [SerializeField] Transform puntoDisparo;
    [SerializeField] float fuerza;
    [SerializeField] float cadencia;
    [SerializeField] bool esperandoCadencia = false;
    [SerializeField] bool zonaAtaque = false;


    protected void PostDisparar()
    {
        esperandoCadencia = true;
        Invoke("ReiniciarCadencia", cadencia);

    }
    private void ReiniciarCadencia()
    {
        esperandoCadencia = false;
    }

    public void Disparar()
    {
        GameObject proyectil = Instantiate(prefabBala, puntoDisparo.position, puntoDisparo.rotation);
        proyectil.GetComponent<Rigidbody>().AddForce(puntoDisparo.forward * fuerza);
        PostDisparar();
    }

    private void Update()
    {
        distanceToPlayer = Vector3.Distance(transform.position, player.transform.position);

        if (distanceToPlayer < attackDistance)
        {
            transform.LookAt(player.transform);
            Quaternion q = Quaternion.LookRotation(player.transform.position - transform.position);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, q, Time.deltaTime * speed);
            zonaAtaque = true;
        }
        else
        {
            zonaAtaque = false;
        }

        if (zonaAtaque == true && esperandoCadencia == false)
        {
            Disparar();
        }
    }

    public void Morir()
    {

        Instantiate(prefabExplosion, transform.position, transform.rotation);
        Destroy(gameObject);
    }

    public void RecibirDanyo(int danyoRecibido)
    {
        vida = vida - danyoRecibido;

        if (vida <= 0)
        {
            Morir();
        }
    }
}