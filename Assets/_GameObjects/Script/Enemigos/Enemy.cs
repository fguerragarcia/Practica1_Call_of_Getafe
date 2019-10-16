using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    //ESTADO ENEMIGO
    protected enum ESTADO {Normal,Siguiendo};
    protected ESTADO estado = ESTADO.Normal;


    public int vida;
    public int danyo;//Que infringe al player
    public GameObject prefabExplosion;
    [SerializeField] TextMesh textoVida;
    public GameObject player;
    


    public void Start()
    {
        player = GameObject.Find("Player");
        
    }

    private void Update()
    {
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
