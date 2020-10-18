using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool isPaused = false;
    public GameObject pausePanel;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Resume()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }
    public void Pause()
    {

        pausePanel.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }
    public void  Quit()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }
    public void Menu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("LevelSelect");
    }
    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
