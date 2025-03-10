using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    // Start is called before the first frame update

    public static bool GameIsPaused=false;

    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {

            if (GameIsPaused) {

                Resume();

            }
            else
            {

                Pause();
            }

        }
        
        
    }

    void Pause()
    {

        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;


    }

    public void Resume() { 
    
    pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    
    
    }

    public void LoadMenu() {
        Time.timeScale = 1f;

    }

    public void QuitGame() {


        Debug.Log("Quitting game");
        Application.Quit();
    }

}
