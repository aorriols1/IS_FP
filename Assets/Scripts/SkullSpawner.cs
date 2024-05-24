using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SkullSpawner : MonoBehaviour
{
    public GameObject skull; // El objeto Skull que se desactivar� y luego activar�
    public float spawnDelay = 10.0f; // Tiempo en segundos antes de que el Skull aparezca

    void Start()
    {
        if (skull != null)
        {
            skull.SetActive(false); // Aseg�rate de que el Skull est� desactivado al inicio
            Invoke("ActivateSkull", spawnDelay); // Llama a ActivateSkull despu�s de spawnDelay segundos
        }
    }

    void ActivateSkull()
    {
        if (skull != null)
        {
            skull.SetActive(true); // Activa el objeto Skull
        }
    }
}
