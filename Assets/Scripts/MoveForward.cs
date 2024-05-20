using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MoveForward : MonoBehaviour
{
    public float speed = 5f; // Velocidad del movimiento

    void Update()
    {
        // Mueve el objeto hacia adelante basado en su propia dirección
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}

