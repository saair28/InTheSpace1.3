using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuzPalanca : MonoBehaviour
{
    public Color Rojo;
    public Color Verde;
    public Color Amarillo;
    public Renderer render;
    public Light luz;


    public GameObject Palanca;

    public bool palanca1;
    public bool palanca2;
    public bool palanca3;

    public bool verde;
    public bool rojo;
    public bool amarillo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (palanca1)
        {
            verde = Palanca.GetComponent<ActivadoSwitcher1>().Verde;
            rojo = Palanca.GetComponent<ActivadoSwitcher1>().Roja;

            if (verde && rojo == false)
            {
                render = GetComponent<Renderer>();
                render.material.color = Verde;
                luz.color = Verde;
            }
            if (rojo && verde == false)
            {
                render = GetComponent<Renderer>();
                render.material.color = Rojo;
                luz.color = Rojo;
            }
        }
        if (palanca2)
        {
            verde = Palanca.GetComponent<ActivadorSwitcher2>().Verde;
            rojo = Palanca.GetComponent<ActivadorSwitcher2>().Rojo;
            amarillo = Palanca.GetComponent<ActivadorSwitcher2>().Amarillo;

            if (verde && amarillo == false)
            {
                render = GetComponent<Renderer>();
                render.material.color = Verde;
                luz.color = Verde;
            }
            if (rojo && verde == false && amarillo == false)
            {
                render = GetComponent<Renderer>();
                render.material.color = Rojo;
                luz.color = Rojo;
            }

            if (amarillo && rojo == false && verde == false)
            {
                render = GetComponent<Renderer>();
                render.material.color = Amarillo;
                luz.color = Amarillo;
            }
        }
        if (palanca3)
        {
            verde = Palanca.GetComponent<ActivadorSwitch3>().Verde;
            rojo = Palanca.GetComponent<ActivadorSwitch3>().Rojo;
            amarillo = Palanca.GetComponent<ActivadorSwitch3>().Amarillo;

            if (verde  && amarillo == false)
            {
                render = GetComponent<Renderer>();
                render.material.color = Verde;
                luz.color = Verde;
            }
            if (rojo && verde == false && amarillo == false)
            {
                render = GetComponent<Renderer>();
                render.material.color = Rojo;
                luz.color = Rojo;
            }

            if (amarillo && rojo == false && verde == false)
            {
                render = GetComponent<Renderer>();
                render.material.color = Amarillo;
                luz.color = Amarillo;
            }
        }
      
    }
}
