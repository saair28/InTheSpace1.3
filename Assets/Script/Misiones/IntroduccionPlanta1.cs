using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroduccionPlanta1 : MonoBehaviour
{
   // AudioSource audioSource;
    AudioManager my_audio_script;
    public GameObject my_audio;
    public bool toggleAudio;
    public float b;
    public float a;
    public bool c;
    public bool toggleAudio2;
    public GameObject IntroP1;
    //public GameObject Intro;
    // Start is called before the first frame update
    void Start()
    {
        my_audio_script = my_audio.GetComponent<AudioManager>();
        //audioSource = my_audio_script.GetComponent<AudioSource>();
        toggleAudio = false;
        b = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (c == true)
        {
            if (b > 2)
            {

                Destroy(IntroP1);
                //Intro.SetActive(false);

            }
            else
            {
                a = Time.deltaTime / 5;
                
            }
            b = b + a; //Time.deltaTime/10;
            Debug.Log(b);
        }
        
        if (FindObjectOfType<AudioManager>().IsPlaying("Tutorial1") == true)
        {
            toggleAudio = false;
        }
        else
        {
            toggleAudio = true;
        }

        if (toggleAudio == true && FindObjectOfType<AudioManager>().IsPlaying("Tuto2") == false)
        {
            FindObjectOfType<AudioManager>().Play("IntroduccionPlanta1Audio");
            toggleAudio = false;
            c = true;
            
        }

        

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {

            toggleAudio = true;
            
            
            /*
            if (FindObjectOfType<AudioManager>().IsPlaying("Tutorial1") == false)
            {

                //FindObjectOfType<AudioManager>.pla
                FindObjectOfType<AudioManager>().Play("IntroduccionPlanta1Audio");
                //toggleAudio = true;

            }else if (FindObjectOfType<AudioManager>().IsPlaying("Tutorial1") == true)
            {
                // FindObjectOfType<AudioManager>().Pause("IntroduccionPlanta1Audio");

                //toggleAudio = false;
            }*/

        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            if (FindObjectOfType<AudioManager>().IsPlaying("IntroduccionPlanta1Audio") == true)
            {
                FindObjectOfType<AudioManager>().Pause("IntroduccionPlanta1Audio");
            }

            
        }
    }
}
