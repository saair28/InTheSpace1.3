using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agarrar : MonoBehaviour
{
    public bool Sujetar = true;

    //public static Agarrar instance;

    public bool agarrado;

    public bool Entrar = false;

    public CabinaOxigeno cabina;

    public void Update()
    {
       // Player player = new Player();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Sujetar")
        {
            other.GetComponentInParent<Player2>().Manos = this.gameObject;

            Entrar = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Sujetar")
        {
            other.GetComponentInParent<Player2>().Manos = null;

            Entrar = false;
        }
    }
    
}
