using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUp : MonoBehaviour
{
    /*
    public bool estaAgarrado = false;

    public Transform manos;

    public bool ocupado;

    public Rigidbody rb;

    public bool tomado = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        estaAgarrado = Player2.instance.loToma;

        ocupado = Player2.instance.manosOcupadas;

        if (tomado == true)
        {

            if (estaAgarrado == true)
            {
                if (ocupado == false)
                {
                    EstaCerca();
                }
               
            }
            else
            {
                Sale();
            }
        }
       
    }
    private void EstaCerca()
    {
        
            GetComponent<Rigidbody>().useGravity = false;
            this.transform.position = manos.position;
            this.transform.parent = GameObject.Find("Agarrar").transform;
            GetComponent<Collider>().enabled = false;
       
    }

     void Sale()
    {
            this.transform.parent = null;
            GetComponent<Rigidbody>().useGravity = true;
            GetComponent<Collider>().enabled = true;
       
            
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Sujetar")
        {
            tomado = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Sujetar")
        {
            tomado = false;
        }
    }
    */
}
