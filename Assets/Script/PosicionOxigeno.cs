using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosicionOxigeno : MonoBehaviour
{
    public bool loPosicionas  = false;

    public bool agarrado;

    public void Start()
    {
        //  instance = this;

        
    }

    private void Update()
    {
        // cabina = CabinaOxigeno.instance;

        agarrado = Player2.instance.LoSujeta;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ponlo")
        {
            CabinaOxigeno cabina = other.GetComponent<CabinaOxigeno>();

            if (cabina != null && cabina.PreguntarLibre())
            {
                cabina.Posicion = this.gameObject;


                loPosicionas = true;
            }
            else
            {
                loPosicionas = false;
            }
        }
    }

   /* private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Ponlo")
        {
            CabinaOxigeno cabina = other.GetComponent<CabinaOxigeno>();

            if (cabina != null && cabina.PreguntarLibre())
            {
                cabina.Posicion = ;


                Entrar = false;
            }
        }
    }
    */
}
