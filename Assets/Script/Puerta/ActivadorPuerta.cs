using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivadorPuerta : MonoBehaviour
{
    public bool playerEnArea;
    public bool playerSalioDelArea;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            playerEnArea = true;
            //playerSalioDelArea = false;

        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            playerEnArea = false;
            playerSalioDelArea = true;

        }
    }
}
