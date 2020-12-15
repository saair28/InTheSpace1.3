using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuertaTutorial : MonoBehaviour
{
    public bool playerEnArea;
    public bool playerSalioDelArea;
    public GameObject Puerta;
    public bool sonar;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        sonar = Puerta.GetComponent<TutorialPuer>().abrir;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && sonar == true)
        {
            playerEnArea = true;
            //playerSalioDelArea = false;
            FindObjectOfType<AudioManager>().Play("AudioPuerta");

        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player" && sonar == true)
        {
            playerEnArea = false;
            playerSalioDelArea = true;

        }
    }
}
