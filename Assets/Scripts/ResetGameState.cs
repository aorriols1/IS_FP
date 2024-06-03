using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetGameState : MonoBehaviour
{
    void Start()
    {
        if (GameManager.instance != null)
        {
            GameManager.instance.ResetHasWon();
        }
    }
}
