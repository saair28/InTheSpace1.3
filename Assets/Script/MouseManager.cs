using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseManager : MonoBehaviour
{
    public bool mouseActivo = false;
    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        if (mouseActivo == true)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;

        }
        if (mouseActivo == false)
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }

     
}
