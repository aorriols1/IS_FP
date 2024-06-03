using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LoadingScenes : MonoBehaviour
{
    // Tiempo en segundos antes de cambiar de escena
    public float delay = 5.0f;
    // Nombre de la escena a la que quieres cambiar
    public string sceneName = "Scene2"; // Default scene name

    private static bool player1Touched = false;
    private static bool player2Touched = false;

    void OnTriggerEnter(Collider other)
    {
        // Comprueba qué jugador ha tocado el collider
        if (other.CompareTag("Player1"))
        {
            player1Touched = true;
            Debug.Log("Player 1 touched the collider.");
        }
        else if (other.CompareTag("Player2"))
        {
            player2Touched = true;
            Debug.Log("Player 2 touched the collider.");
        }

        // Si ambos jugadores han tocado sus colliders, inicia la corrutina
        if (player1Touched && player2Touched)
        {
            CoroutineManager.Instance.StartRoutine(ChangeSceneAfterDelay());
        }
    }

    public void SetSceneName(string newSceneName)
    {
        sceneName = newSceneName;
    }

    IEnumerator ChangeSceneAfterDelay()
    {
        Debug.Log("Start coroutine");
        // Espera por el tiempo especificado
        yield return new WaitForSeconds(delay);
        Debug.Log("Continue coroutine");
        // Reset static variables before loading the scene
        player1Touched = false;
        player2Touched = false;
        // Cambia a la nueva escena
        SceneManager.LoadScene(sceneName);
    }

}
