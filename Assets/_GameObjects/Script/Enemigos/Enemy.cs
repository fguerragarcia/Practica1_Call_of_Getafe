using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int vida;
    public int danyo;//Que infringe al player
    public GameObject prefabExplosion;
    [SerializeField] TextMesh textoVida;

    public void Start()
    {
        textoVida = GetComponent<TextMesh>();
        print("TM:" + textoVida);
        textoVida.text = vida.ToString();


    }

    public void Atacar() {



    }

    public void Morir() {

        Instantiate(prefabExplosion, transform.position, transform.rotation);
        Destroy(gameObject);

    }

    public void RecibirDanyo(int danyoRecibido)
    {
        vida = vida - danyoRecibido;

        if (vida <= 0) {
            Morir();
        }


    }

}
