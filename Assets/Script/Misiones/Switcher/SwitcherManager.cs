using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitcherManager : MonoBehaviour
{
    public bool ganaste;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (FindObjectOfType<EndMark>().Switch1EnEndMark == true && FindObjectOfType<EndMark>().Switch3EnEndMark == true && FindObjectOfType<EndMark>().Switch2EnEndMark == true)
        {
            Debug.Log("Ganaste");
            ganaste = true;
        }
        else
        {
            ganaste = false;
        }
    }
}
