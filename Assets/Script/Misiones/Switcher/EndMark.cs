using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndMark : MonoBehaviour
{
    public bool Switch1EnEndMark;
    public bool Switch2EnEndMark;
    public bool Switch3EnEndMark;
    public bool inmunity2;
    // Start is called before the first frame update
    void Start()
    {
        inmunity2 = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Switch1")
        {
            Switch1EnEndMark = true;

        }
        if (other.tag == "Switch2")
        {
            Switch2EnEndMark = true;

        }
        if (other.tag == "Switch3")
        {
            Switch3EnEndMark = true;

        }
        inmunity2 = false;
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Switch1")
        {
            Switch1EnEndMark = false;

        }
        if (other.tag == "Switch2")
        {
            Switch2EnEndMark = false;

        }
        if (other.tag == "Switch3")
        {
            Switch3EnEndMark = false;

        }
        inmunity2 = true;
    }
}
