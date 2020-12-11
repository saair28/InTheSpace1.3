using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMark : MonoBehaviour
{
    public bool Switch1EnStartMark;
    public bool Switch2EnStartMark;
    public bool Switch3EnStartMark;
    public bool inmunity1;
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
        if (other.tag == "Switch1")
        {
            Switch1EnStartMark = true;

        }
        if (other.tag == "Switch2")
        {
            Switch2EnStartMark = true;

        }
        if (other.tag == "Switch3")
        {
            Switch3EnStartMark = true;

        }
        inmunity1 = false;

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Switch1")
        {
            Switch1EnStartMark = false;

        }
        if (other.tag == "Switch2")
        {
            Switch2EnStartMark = false;

        }
        if (other.tag == "Switch3")
        {
            Switch3EnStartMark = false;

        }
        inmunity1 = true;
    }
}
