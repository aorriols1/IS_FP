using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int player1Points = 0;
    public int player2Points = 0;
    private bool hasWon = false; // Flag to indicate if a player has won

    public bool HasWon // Public getter for hasWon
    {
        get { return hasWon; }
    }

    void Awake()
    {
        // Ensure there's only one instance of GameManager
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddPoint(int playerNumber)
    {
        if (hasWon) return; // Prevent further points if a player has won

        if (playerNumber == 1)
        {
            player1Points++;
            Debug.Log("Player 1 Points: " + player1Points);
            hasWon = true; // Set the flag indicating a player has won
        }
        else if (playerNumber == 2)
        {
            player2Points++;
            Debug.Log("Player 2 Points: " + player2Points);
            hasWon = true; // Set the flag indicating a player has won
        }
    }

    public void SubtractPoint(int playerNumber)
    {
        if (playerNumber == 1)
        {
            player1Points--;
            Debug.Log("Player 1 Points: " + player1Points);
        }
        else if (playerNumber == 2)
        {
            player2Points--;
            Debug.Log("Player 2 Points: " + player2Points);
        }
    }

    public void TransferPoint(int fromPlayer, int toPlayer)
    {
        if (fromPlayer == 1 && player1Points > 0)
        {
            player1Points--;
            player2Points++;
            Debug.Log("Player 1 Points: " + player1Points);
            Debug.Log("Player 2 Points: " + player2Points);
        }
        else if (fromPlayer == 2 && player2Points > 0)
        {
            player2Points--;
            player1Points++;
            Debug.Log("Player 1 Points: " + player1Points);
            Debug.Log("Player 2 Points: " + player2Points);
        }
    }
}
