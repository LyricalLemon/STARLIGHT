using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Diagnostics;

public class PauseMenu : MonoBehaviour
{
    public string bugReportURL = "https://github.com/LyricalLemon/STARLIGHT/issues";
    [SerializeField] public static bool IsPaused = false;
    public GameObject PauseMenuUI;
    public void Resume()
    {
        PauseMenuUI.SetActive(false);
        SceneManager.UnloadSceneAsync("Pause");
        Time.timeScale = 1f;
        Destroy(gameObject);
        IsPaused = false;
    } 
    public void Pause()
    {
        PauseMenuUI.SetActive(true);
        SceneManager.LoadSceneAsync("Pause", LoadSceneMode.Additive);
        Time.timeScale = 0f;
        IsPaused = true;
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("StartMenu");
        Time.timeScale = 1f;
    }
    public void Restart()
    {
        SceneManager.LoadScene("GAME");
        Time.timeScale = 1f;
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void ReportBug()
    {
        Process.Start(bugReportURL);
    }
    public void GiveFeedback()
    {
        Process.Start(bugReportURL);
    }
    public void back()
    {
        SceneManager.UnloadSceneAsync("ReportBug");
    }
    public void Back()
    {
        SceneManager.UnloadSceneAsync("GetFeedback");
    }
    public void BaCK()
    {
        SceneManager.LoadScene("StartMenu");
    }
    public void UnloadSecretButton()
    {
        SceneManager.LoadScene("StartMenu");
    }
}
