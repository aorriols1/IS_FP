using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThieveSpawner : MonoBehaviour
{
    public GameObject thieve; // El objeto Thieve que se desactivar� y luego activar�
    public float spawnDelay = 10.0f; // Tiempo en segundos antes de que el Thieve aparezca

    void Start()
    {
        if (thieve != null)
        {
            thieve.SetActive(false); // Aseg�rate de que el Thieve est� desactivado al inicio
            Invoke("ActivateThieve", spawnDelay); // Llama a ActivateThieve despu�s de spawnDelay segundos
        }
    }

    void ActivateThieve()
    {
        if (thieve != null)
        {
            thieve.SetActive(true); // Activa el objeto Thieve
        }
    }
}

