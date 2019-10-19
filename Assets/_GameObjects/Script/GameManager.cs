using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int numeroEnemigos;

   
    void Update()
    {
        numeroEnemigos = GameObject.FindObjectsOfType<Enemy>().Length;
        StartCoroutine("ComprobarFinJuego");
    }

    IEnumerator ComprobarFinJuego() {

        while (numeroEnemigos > 0) {
            yield return new WaitForSeconds(0.1f);
            numeroEnemigos = GameObject.FindObjectsOfType<Enemy>().Length;
        }
        print("FIN DEL JUEGO");
    }
}
