using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour
{
    [Header("Tiempo entre disparos(segundos)")]
    [Range(0,10)]
    [SerializeField] float cadencia; //tiempo entre disparos(ms)

    [Header("Capacidad balas en 1 cargador")]
    [SerializeField] int capacidadCargardor;

    [Header("Tiempo de recarga")]
    [Range(0, 3)]
    [SerializeField] float tiempoRecarga;

    [Header("Cargadores que puede llevar encima")]
    [Range(0, 10)]
    [SerializeField] int numeroCargadores;

    private int municionCargador;

    public void IntentarDisparar() {
    }

    private void Disparar() {

    }

    public void Recargar()
    {

    }

    public void IncrementarCargador(int numeroCargadores)
    {

    }



}
