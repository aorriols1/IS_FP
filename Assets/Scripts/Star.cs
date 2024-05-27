using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Star : MonoBehaviour
{
    public AudioSource audioSource; // El AudioSource para reproducir el sonido

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player1"))
        {
            Debug.Log("Player1 picked up the star.");
            GameManager.instance.AddPoint(1); // Suma un punto al Jugador 1
            PlaySoundAndDestroy();
        }
        else if (other.CompareTag("Player2"))
        {
            Debug.Log("Player2 picked up the star.");
            GameManager.instance.AddPoint(2); // Suma un punto al Jugador 2
            PlaySoundAndDestroy();
        }
    }

    private void PlaySoundAndDestroy()
    {
        if (audioSource != null)
        {
            // Desacopla el audioSource del objeto y lo reproduce
            audioSource.transform.parent = null;
            audioSource.Play();

            // Destruye el GameObject del audio despu�s de que el sonido haya terminado de reproducirse
            Destroy(audioSource.gameObject, audioSource.clip.length);
        }

        // Destruye el GameObject de la estrella inmediatamente
        Destroy(gameObject);
    }
}


