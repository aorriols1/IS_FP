using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class StarSpawner : MonoBehaviour
{
    public GameObject star; // El objeto Star que se desactivar� y luego activar�
    public float spawnDelay = 10.0f; // Tiempo en segundos antes de que el Star aparezca

    void Start()
    {
        if (star != null)
        {
            star.SetActive(false); // Aseg�rate de que el Star est� desactivado al inicio
            Invoke("ActivateStar", spawnDelay); // Llama a ActivateStar despu�s de spawnDelay segundos
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

