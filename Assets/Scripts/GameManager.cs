using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int player1Points = 0;
    public int player2Points = 0;

    void Awake()
    {
        // Asegurarse de que solo haya una instancia de GameManager
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
        if (playerNumber == 1)
        {
            player1Points++;
            Debug.Log("Puntos del Jugador 1: " + player1Points);
        }
        else if (playerNumber == 2)
        {
            player2Points++;
            Debug.Log("Puntos del Jugador 2: " + player2Points);
        }
    }
}
