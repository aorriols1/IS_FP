using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class ThieveSpawner : MonoBehaviour
{
    public GameObject thieve; // El objeto Thieve que se desactivará y luego activará
    public float spawnDelay = 10.0f; // Tiempo en segundos antes de que el Thieve aparezca

    void Start()
    {
        if (thieve != null)
        {
            thieve.SetActive(false); // Asegúrate de que el Thieve esté desactivado al inicio
            Invoke("ActivateThieve", spawnDelay); // Llama a ActivateThieve después de spawnDelay segundos
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

