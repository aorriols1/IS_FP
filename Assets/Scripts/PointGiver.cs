using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointGiver : MonoBehaviour
{
    public int playerNumber; // 1 for Player 1, 2 for Player 2

    void OnTriggerEnter(Collider other)
    {
        if (!GameManager.instance.HasWon) // Use the public getter to check if no player has won yet
        {
            if (playerNumber == 1 && other.CompareTag("Player1"))
            {
                GameManager.instance.AddPoint(1);
                Destroy(gameObject); // Destroy the point-giving object
            }
            else if (playerNumber == 2 && other.CompareTag("Player2"))
            {
                GameManager.instance.AddPoint(2);
                Destroy(gameObject);
            }
        }
    }
}
