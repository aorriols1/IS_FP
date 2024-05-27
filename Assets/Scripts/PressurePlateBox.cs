using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PressurePlateBox : MonoBehaviour
{
    public GameObject nextPressurePlate; // La siguiente pressure plate a activar
    public AudioSource audioSource;      // El AudioSource externo para reproducir el sonido

    private bool activated = false; // Variable para rastrear si la pressure plate está activada

    private void OnTriggerEnter(Collider other)
    {
        if (!activated && other.CompareTag("Player1"))
        {
            // Reproduce el sonido
            if (audioSource != null)
            {
                audioSource.Play();
            }

            // Desactiva la pressure plate actual
            StartCoroutine(DeactivateAfterSound());

            // Activa la siguiente pressure plate si está definida
            if (nextPressurePlate != null)
            {
                nextPressurePlate.SetActive(true);
            }

            activated = true;
        }
    }

    private IEnumerator DeactivateAfterSound()
    {
        // Espera hasta que el sonido termine de reproducirse
        if (audioSource != null)
        {
            yield return new WaitForSeconds(audioSource.clip.length);
        }

        // Desactiva el GameObject
        gameObject.SetActive(false);
    }
}

