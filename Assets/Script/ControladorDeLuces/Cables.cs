using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cables : MonoBehaviour
{
    public bool message = false;
    //public GameObject circle_Img;
    //public GameObject circle;
    public GameObject my_circle;
    public GameObject canvasCircle;
    Circle my_circle_script;
    //public GameObject circleFill;
    public bool prenderLuces;
    public bool enRangoDeArreglo = false;

    // Start is called before the first frame update
    void Start()
    {
        my_circle_script = my_circle.GetComponent<Circle>();

        my_circle.SetActive(false);
        canvasCircle.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        ManejoDeCables();
        /*
        if(my_circle_script.desactivaCircle == true)
        {
            DesactivaCircle();
        }*/
        
        
        DeboPrenderLuces();
        
    }
    /*
    void OnMouseOver()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            message = true;
            //Debug.Log("activaCables");
        }
    }*/

    public void ManejoDeCables()
    {   
        if(enRangoDeArreglo == true)
        { 
            if (Input.GetKeyDown(KeyCode.E))
            {
                my_circle.SetActive(true);
                canvasCircle.SetActive(true);
            }
            else if (my_circle_script.desactivaCircle == true)
            {
                my_circle.SetActive(false);
                canvasCircle.SetActive(false);
                //my_circle_script.progress = 0;
                prenderLuces = true; ;
            }
        } else
        {
            my_circle.SetActive(false);
            canvasCircle.SetActive(false);
            my_circle_script.progress = 0;
            
        }
    }
    /*
    public void DesactivaCircle()
    {
        circleFill.SetActive(false);
        circle.SetActive(false);
        circle_Img.SetActive(false);
        my_circle_script.progress = 0;
        prenderLuces = true;
    }*/

    public bool DeboPrenderLuces()
    {
        if (prenderLuces == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            enRangoDeArreglo = true;
            
        } 
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            enRangoDeArreglo = false;

        }
    }
}
