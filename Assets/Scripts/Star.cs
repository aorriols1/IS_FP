using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Star : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player1"))
        {
            GameManager.instance.AddPoint(1);
            Destroy(gameObject); // Elimina el objeto Star después de que sea recogido
        }
        else if (other.CompareTag("Player2"))
        {
            GameManager.instance.AddPoint(2);
            Destroy(gameObject); // Elimina el objeto Star después de que sea recogido
        }
    }
}

