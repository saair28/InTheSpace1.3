using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaSwitcher : MonoBehaviour
{
    public bool PlayerEnArea;
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
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            PlayerEnArea = false;

        }
    }
}
