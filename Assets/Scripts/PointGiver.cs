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
                GameManager.instance.SetHasWon(true); // Set hasWon to true
                Destroy(gameObject); // Destroy the point-giving object
                Debug.Log("Player1 picked up the last Plate.");
            }
            else if (playerNumber == 2 && other.CompareTag("Player2"))
            {
                GameManager.instance.AddPoint(2);
                GameManager.instance.SetHasWon(true); // Set hasWon to true
                Destroy(gameObject);
                Debug.Log("Player2 picked up the last Plate.");
            }
        }
    }
}
