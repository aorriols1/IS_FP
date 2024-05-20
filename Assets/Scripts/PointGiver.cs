using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PointGiver : MonoBehaviour
{
    public int playerNumber; // 1 para Jugador 1, 2 para Jugador 2

    void OnTriggerEnter(Collider other)
    {
        if (playerNumber == 1 && other.CompareTag("Player1"))
        {
            GameManager.instance.AddPoint(1);
            Destroy(gameObject); // Elimina el objeto que otorga puntos
        }
        else if (playerNumber == 2 && other.CompareTag("Player2"))
        {
            GameManager.instance.AddPoint(2);
            Destroy(gameObject);
        }
    }
}


