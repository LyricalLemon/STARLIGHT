using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseButton : MonoBehaviour
{
    [SerializeField] public static bool IsPaused = false;
    public GameObject PauseMenuUI;
    public void Resume()
    {
        SceneManager.UnloadSceneAsync("Pause");
        Time.timeScale = 1f;
        IsPaused = false;
    } 
    public void Pause()
    {
        SceneManager.LoadSceneAsync("Pause", LoadSceneMode.Additive);
        Time.timeScale = 0f;
        IsPaused = true;
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }
    public void Restart()
    {
        SceneManager.LoadScene("GAME");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
