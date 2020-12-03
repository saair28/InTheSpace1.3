using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public bool GameIsPaused = false;
    public GameObject my_CursorMana;
    MouseManager my_CursorMana_script;
    public GameObject pauseMenuUI;
    public bool resumeSounds = false;
    // Start is called before the first frame update
    void Start()
    {
        my_CursorMana_script = my_CursorMana.GetComponent<MouseManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            
            if (GameIsPaused == true)
            {
                Resume();
                resumeSounds = true;
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume ()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        my_CursorMana_script.mouseActivo = false;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        my_CursorMana_script.mouseActivo = true;
        GameIsPaused = true;


    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
