using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skull : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player1"))
        {
            GameManager.instance.SubtractPoint(2); // Resta un punto al Jugador 2
            Destroy(gameObject); // Elimina el objeto Skull después de que sea recogido
        }
        else if (other.CompareTag("Player2"))
        {
            GameManager.instance.SubtractPoint(1); // Resta un punto al Jugador 1
            Destroy(gameObject); // Elimina el objeto Skull después de que sea recogido
        }
    }
}

