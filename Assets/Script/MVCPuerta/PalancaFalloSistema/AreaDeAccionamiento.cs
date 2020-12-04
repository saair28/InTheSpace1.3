using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaDeAccionamiento : MonoBehaviour
{
    public bool PlayerEnArea;
    public bool misionCUMPLIDA;

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
            PlayerEnArea = true;

        }
        if (other.tag == "EndPoint")
        {
            misionCUMPLIDA = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            PlayerEnArea = false;

        }
    }

       
}
