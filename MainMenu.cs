using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("GAME");
    }
    public void Loudout()
    {
        SceneManager.LoadScene("Loadout");
    }
    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void reportBug()
    {
        SceneManager.LoadSceneAsync("ReportBug", LoadSceneMode.Additive);
    }
    public void GetFeedback()
    {
        SceneManager.LoadSceneAsync("GetFeedback", LoadSceneMode.Additive);
    }

}
