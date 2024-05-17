using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PressurePlateBox2 : MonoBehaviour
{
    public GameObject nextPressurePlate; // La siguiente pressure plate a activar

    private bool activated = false; // Variable para rastrear si la pressure plate está activada

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"OnTriggerEnter {gameObject.name}");
        if (!activated && other.CompareTag("Player2"))
        {
            // Desactiva la pressure plate actual
            gameObject.SetActive(false);
            
            // Activa la siguiente pressure plate si está definida
            if (nextPressurePlate != null)
            {
                nextPressurePlate.SetActive(true);
            }
            
            activated = true;
        }
    }
}
