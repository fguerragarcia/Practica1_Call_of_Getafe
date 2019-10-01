using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Teleport : MonoBehaviour
{
    [SerializeField] string nombreEscena;
    [SerializeField] float delay;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player") {
            Invoke("CambiarEscena", delay);
        }
    }
    private void CambiarEscena() {

        SceneManager.LoadScene(nombreEscena);

    }

}
