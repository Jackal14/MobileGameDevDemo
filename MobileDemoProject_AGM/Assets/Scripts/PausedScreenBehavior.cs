using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PausedScreenBehavior : MainMenuBehavior
{
    public static bool paused;

    public GameObject pauseMenu;

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void SetPauseMenu(bool isPaused)
    {
        paused = isPaused;

        Time.timeScale = (paused) ? 0 : 1;

        pauseMenu.SetActive(paused);
    }

    private void Start()
    {
        SetPauseMenu(false);
    }
}
