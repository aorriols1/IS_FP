using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thieve : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player1"))
        {
            GameManager.instance.TransferPoint(2, 1); // Transfiere un punto del Jugador 2 al Jugador 1
            Destroy(gameObject); // Elimina el objeto Thieve después de que sea recogido
        }
        else if (other.CompareTag("Player2"))
        {
            GameManager.instance.TransferPoint(1, 2); // Transfiere un punto del Jugador 1 al Jugador 2
            Destroy(gameObject); // Elimina el objeto Thieve después de que sea recogido
        }
    }
}

