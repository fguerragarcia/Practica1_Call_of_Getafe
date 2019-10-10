using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puntuacion : MonoBehaviour
{
    [SerializeField] TextMesh PanelPuntuacion;
    public int puntuacion;

    void Update()
    {
        PanelPuntuacion = GetComponent<TextMesh>();
        PanelPuntuacion.text = puntuacion.ToString();
    }
}
