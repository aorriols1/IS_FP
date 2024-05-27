using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Skull : MonoBehaviour
{
    public AudioSource audioSource; // El AudioSource externo para reproducir el sonido

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player1"))
        {
            Debug.Log("Player1 picked up the skull.");
            GameManager.instance.SubtractPoint(2); // Resta un punto al Jugador 2
            PlaySoundAndDestroy();
        }
        else if (other.CompareTag("Player2"))
        {
            Debug.Log("Player2 picked up the skull.");
            GameManager.instance.SubtractPoint(1); // Resta un punto al Jugador 1
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

            // Destruye el GameObject del audio después de que el sonido haya terminado de reproducirse
            Destroy(audioSource.gameObject, audioSource.clip.length);
        }

        // Destruye el GameObject de la calavera inmediatamente
        Destroy(gameObject);
    }
}



