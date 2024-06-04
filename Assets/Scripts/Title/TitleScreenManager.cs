using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreenManager : MonoBehaviour
{
    public void StartGame()
    {
        Debug.Log("Start button clicked");
        SceneManager.LoadScene("Tutorial"); // Go to the Tutorial scene
    }

    public void QuitGame()
    {
        Debug.Log("Quit button clicked");
        Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; // Stop playing the scene in the editor
#endif
    }
}
