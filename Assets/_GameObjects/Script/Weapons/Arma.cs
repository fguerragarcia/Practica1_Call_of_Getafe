using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Arma : MonoBehaviour
{
    [Header("Tiempo entre disparos(segundos)")] 
    [Range(0,10)]
    [SerializeField] float cadencia; //tiempo entre disparos(ms)

    [Header("Capacidad balas en 1 cargador")]
    [SerializeField] int capacidadCargador;

    [Header("Tiempo de recarga")]
    [Range(0, 5)]
    [SerializeField] float tiempoRecarga;

    [Header("Cargadores que puede llevar encima")]
    [Range(0, 10)]
    [SerializeField] int numeroCargadores;

    [Header("Variables de estado")]
    [SerializeField] bool recargando = false;
    [SerializeField] bool esperandoCadencia = false;

    [SerializeField] int municionCargador;

    [Header("Sonidos")]
    [SerializeField] AudioClip acShoot;
    [SerializeField] AudioClip acReload;
    [SerializeField] AudioClip acFail;
    public AudioSource audioSource;



    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Awake()
    {
        municionCargador = capacidadCargador;
    }

    public void IntentarDisparar() {

        bool puedeDisparar = municionCargador > 0 && recargando == false && esperandoCadencia == false;
        if (puedeDisparar)
        {
            Disparar();
            audioSource.PlayOneShot(acShoot);
            PostDisparar();
        }
        else{
             audioSource.PlayOneShot(acFail);
        }
        
    }

    public abstract void Disparar();

    public void Recargar()
    {
        if (numeroCargadores > 0 && municionCargador != capacidadCargador) {

            recargando = true;
            audioSource.PlayOneShot(acReload);
            municionCargador = capacidadCargador;
            numeroCargadores--;
            Invoke("ReiniciarCargando", tiempoRecarga);
           

        }
        
    }

   

    public void IncrementarCargador(int numeroCargadores)
    {
        this.numeroCargadores = this.numeroCargadores + numeroCargadores;
    }

    protected void PostDisparar() {

        municionCargador--;

        esperandoCadencia = true;
        Invoke("ReiniciarCadencia", cadencia);
        
    }
    private void ReiniciarCadencia() {
        esperandoCadencia = false;
    }

    private void ReiniciarCargando()
    {
        recargando = false;
    }

}
