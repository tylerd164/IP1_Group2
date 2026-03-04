using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private const string DEMOLEVEL = "DemoLevel";
    public void PlayGame()
    {
        SceneManager.LoadScene(DEMOLEVEL);
    }

    public void Options()
    {
        Debug.Log("Options");
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}