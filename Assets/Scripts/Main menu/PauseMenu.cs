using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [Header("")]

    [SerializeField] private GameObject pauseMenu;

    private bool gameIsPaused;


    public void OnPause()
    {
        if (gameIsPaused == false)
        {
            pauseMenu.SetActive(true);


            gameIsPaused = true;


            Time.timeScale = 0;
        }

        else
        {
            OnResume();
        }
    }


    public void OnResume()
    {
        pauseMenu.SetActive(false);


        gameIsPaused = false;


        Time.timeScale = 1;
    }


    public void backToMainMenu()
    {
        Scene currentScene = SceneManager.GetActiveScene();

        SceneManager.LoadScene(currentScene.name);
    }
}
