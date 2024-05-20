using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class StarSpawner : MonoBehaviour
{
    public GameObject star; // El objeto Star que se desactivará y luego activará
    public float spawnDelay = 10.0f; // Tiempo en segundos antes de que el Star aparezca

    void Start()
    {
        if (star != null)
        {
            star.SetActive(false); // Asegúrate de que el Star esté desactivado al inicio
            Invoke("ActivateStar", spawnDelay); // Llama a ActivateStar después de spawnDelay segundos
        }
    }

    void ActivateStar()
    {
        if (star != null)
        {
            star.SetActive(true); // Activa el objeto Star
        }
    }
}

