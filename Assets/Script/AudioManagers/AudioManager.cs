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
    public static AudioManager instance;
    //public bool audioPlaying;
    public bool isPaused;
    public bool abrir = false;
    public float cronometro = 0;
    public float Abrete;

    // Start is called before the first frame update

    public void Start()
    {
        my_pauseStat_script = my_pauseStat.GetComponent<PauseMenu>();
        my_tuto1_script = my_tuto1.GetComponent<Tutorial1>();
       /*if (FindObjectOfType<Player2>().JugadorEnScena == true)
        {
            Play("AudioFondo");
        }
       */

    }

    void Awake()
    {
        if (instance == null)
            instance = this;
        else
        {

            Destroy(gameObject);
            return;
        }
        //DontDestroyOnLoad(gameObject);
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
    {
        cronometro =  cronometro + 1 * Time.deltaTime;

        if (cronometro >= Abrete)
        {
            abrir = true;
        }
        /*
        if (my_pauseStat_script.GameIsPaused == false)
        {
            
            if (my_tuto1_script.SonidoAudio1 == true) 
            { 
                Play("Tutorial1");
                Debug.Log("HABLa");
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
        /*
        if (s.source.isPlaying == false)
        {
            s.source.Play();
            audioPlaying = true;
            
        }*/
        s.source.Play();
    }
    public void Pause(string name)
    {

        Sound s = Array.Find(sounds, sound => sound.name == name);
        /*
        if (s.source.isPlaying == true)
        {
            audioPlaying = false;
            s.source.Pause();
        }*/
        isPaused = true;
        s.source.Pause();
    }
    /*
    public bool Buscador()
    {
        Sound s = 
    }*/

    public bool IsPlaying(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s.source.isPlaying == true)
        {
            return true;
        } else
        {
            return false;
        }
    }

    public void Resume(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (isPaused== true)
        {
            s.source.UnPause();
            isPaused = false;
        }
    }
    
}
