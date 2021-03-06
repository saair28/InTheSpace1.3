﻿using System.Collections;
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

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        
        my_CursorMana_script.mouseActivo = false;

        
        if (FindObjectOfType<AudioManager>().isPaused == true)
        {
            FindObjectOfType<AudioManager>().Resume("Tutorial1");
            GameIsPaused = false;
        }

        if (FindObjectOfType<AudioManager>().isPaused == true)
        {
            FindObjectOfType<AudioManager>().Resume("MisionCables");
            GameIsPaused = false;
        }

        if (FindObjectOfType<AudioManager>().isPaused == true)
        {
            FindObjectOfType<AudioManager>().Resume("MisionPalanca");
            GameIsPaused = false;
        }

        if (FindObjectOfType<AudioManager>().isPaused == true)
        {
            FindObjectOfType<AudioManager>().Resume("MisionOxigeno");
            GameIsPaused = false;
        }
        if (FindObjectOfType<AudioManager>().isPaused == true)
        {
            FindObjectOfType<AudioManager>().Resume("MisionOxigeno");
            GameIsPaused = false;
        }

        if (FindObjectOfType<AudioManager>().isPaused == true)
        {
            FindObjectOfType<AudioManager>().Resume("MisionesNivel1Completadas");
            GameIsPaused = false;
        }

        if (FindObjectOfType<AudioManager>().isPaused == true)
        {
            FindObjectOfType<AudioManager>().Resume("MisionPlacaDePresion");
            GameIsPaused = false;
        }

        if (FindObjectOfType<AudioManager>().isPaused == true)
        {
            FindObjectOfType<AudioManager>().Resume("MisionesNivel2Completadas");
            GameIsPaused = false;
        }
                
        if (FindObjectOfType<AudioManager>().isPaused == true)
        { 
            FindObjectOfType<AudioManager>().Resume("IntroduccionPlanta1Audio");
            GameIsPaused = false;
        }

        if (FindObjectOfType<AudioManager>().isPaused == true)
        {
            FindObjectOfType<AudioManager>().Resume("IntroduccionPlanta2Audio");
            GameIsPaused = false;
        }

        if (FindObjectOfType<AudioManager>().isPaused == true)
        {
            FindObjectOfType<AudioManager>().Resume("MisionNucleoAudio");
            GameIsPaused = false;
        }
        if (FindObjectOfType<AudioManager>().isPaused == true)
        {
            FindObjectOfType<AudioManager>().Resume("IntroFinalAudio");
            GameIsPaused = false;
        }
        if (FindObjectOfType<AudioManager>().isPaused == true)
        {
            FindObjectOfType<AudioManager>().Resume("Tuto2");
            GameIsPaused = false;
        }
                
            
    }
        
        
        

    

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        my_CursorMana_script.mouseActivo = true;
        GameIsPaused = true;

        if (FindObjectOfType<AudioManager>().audioPlaying== true)
        {
            FindObjectOfType<AudioManager>().Pause("Tutorial1");
        }
        if (FindObjectOfType<AudioManager>().audioPlaying == true)
        {
            FindObjectOfType<AudioManager>().Pause("MisionCables");
        }
        if (FindObjectOfType<AudioManager>().audioPlaying == true)
        {
            FindObjectOfType<AudioManager>().Pause("MisionPalanca");
        }
        
        if (FindObjectOfType<AudioManager>().audioPlaying == true)
        {
            FindObjectOfType<AudioManager>().Pause("MisionOxigeno");
        }
        if (FindObjectOfType<AudioManager>().audioPlaying == true)
        {
            FindObjectOfType<AudioManager>().Pause("MisionesNivel1Completadas");
        }
        if (FindObjectOfType<AudioManager>().audioPlaying == true)
        {
            FindObjectOfType<AudioManager>().Pause("MisionPlacaDePresion");
        }
        if (FindObjectOfType<AudioManager>().audioPlaying == true)
        {
            FindObjectOfType<AudioManager>().Pause("MisionesNivel2Completadas");
        }
        if (FindObjectOfType<AudioManager>().audioPlaying == true)
        {
            FindObjectOfType<AudioManager>().Pause("IntroduccionPlanta1Audio");
        }
        if (FindObjectOfType<AudioManager>().audioPlaying == true)
        {
            FindObjectOfType<AudioManager>().Pause("IntroduccionPlanta2Audio");
        }
        if (FindObjectOfType<AudioManager>().audioPlaying == true)
        {
            FindObjectOfType<AudioManager>().Pause("MisionNucleoAudio");
        }
        if (FindObjectOfType<AudioManager>().audioPlaying == true)
        {
            FindObjectOfType<AudioManager>().Pause("IntroFinalAudio");
        }
        if (FindObjectOfType<AudioManager>().audioPlaying == true)
        {
            FindObjectOfType<AudioManager>().Pause("Tuto2");
        }

        

    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
