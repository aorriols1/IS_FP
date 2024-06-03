using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.InputSystem;
using TMPro;


public class PlayerController7plates : MonoBehaviour
{
    public float speed = 0;
    public TextMeshProUGUI countText;
    public GameObject winTextObject;
    public string playerTag;

    private Rigidbody rb;
    private int count;
    private float movementX;
    private float movementY;

    private bool hasWon = false; // Variable para controlar si el jugador ha ganado

    // Variable estática para determinar si un jugador ya ha ganado
    private static bool gameOver = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;

        SetCountText();
        winTextObject.SetActive(false);
    }

    void SetCountText()
    {
        countText.text = playerTag + " counter: " + count.ToString();
        if (count >= 7 && !hasWon && !gameOver) // Contar hasta 7 platos y verificar si el jugador no ha ganado aún y el juego no ha terminado
        {
            hasWon = true;
            gameOver = true; // Marcar el juego como terminado

            if (gameObject.CompareTag(playerTag)) // Verificar si este jugador es el que ha recogido todas las piezas
            {
                winTextObject.SetActive(true); // Activar el texto de victoria solo para este jugador
            }
        }
    }

    void FixedUpdate()
    {
        if (!hasWon) // Solo mover al jugador si aún no ha ganado
        {
            Vector3 movement = new Vector3(movementX, 0.0f, movementY);
            rb.AddForce(movement * speed);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!hasWon && other.gameObject.CompareTag(playerTag)) // Verificar si el jugador no ha ganado y la colisión es con el jugador actual
        {
            other.gameObject.SetActive(false); // Desactivar el objeto que ha colisionado con el jugador
            count++; // Incrementar el contador de platos recogidos
            SetCountText(); // Actualizar el texto del contador
        }
    }

    void OnDestroy()
    {
        // Resetear gameOver al destruir el objeto (cargar una nueva escena)
        gameOver = false;
    }
}

