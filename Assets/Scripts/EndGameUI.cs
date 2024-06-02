using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EndGameUI : MonoBehaviour
{
    public TextMeshProUGUI player1PointsText;
    public TextMeshProUGUI player2PointsText;
    public TextMeshProUGUI winnerText;

    void Start()
    {
        // Asegúrate de que GameManager esté instanciado y se mantenga en la escena
        if (GameManager.instance != null)
        {
            UpdateUI();
        }
    }

    void UpdateUI()
    {
        player1PointsText.text = "Player 1: " + GameManager.instance.player1Points.ToString() + " points";
        player2PointsText.text = "Player 2: " + GameManager.instance.player2Points.ToString() + " points";

        if (GameManager.instance.player1Points > GameManager.instance.player2Points)
        {
            winnerText.text = "¡Player 1 wins!";
        }
        else if (GameManager.instance.player2Points > GameManager.instance.player1Points)
        {
            winnerText.text = "¡Player 2 wins!";
        }
        else
        {
            winnerText.text = "¡Draw!";
        }
    }
}

