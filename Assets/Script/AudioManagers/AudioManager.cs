using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;
    public GameObject my_pauseStat;
    PauseMenu my_pauseStat_script;
    public GameObject my_tuto1;
    Tutorial1 my_tuto1_script;
    
    // Start is called before the first frame update

    public void Start()
    {
        my_pauseStat_script = my_pauseStat.GetComponent<PauseMenu>();
        my_tuto1_script = my_tuto1.GetComponent<Tutorial1>();
        Play("SonidoFondo");
    }
    void Awake()
    {
        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
        
    }

    public void Update()
    {/*
        if (my_pauseStat_script.GameIsPaused == false)
        {
            
            if (my_tuto1_script.SonidoAudio1 == true) 
            { 
                Play("Tutorial1"); 
            }


        }
        if (my_pauseStat_script.GameIsPaused == true)
        {
            
            if (my_tuto1_script.SonidoAudio1 == true)
            {
                Pause("Tutorial1");
            }
        }*/

    }

    // Update is called once per frame
    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Play();
    }
    public void Pause(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Pause();
    }
}
