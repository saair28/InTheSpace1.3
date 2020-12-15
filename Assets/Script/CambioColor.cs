using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioColor : MonoBehaviour
{
    public Color Default;
    public Color Nuevo;
    public Renderer render;
    public Light luz;

    public GameObject MisionOxigeno;
    public bool puesto1;
    public bool puesto2;
    public bool puesto3;
    public bool puesto4;

    public bool ox1;
    public bool ox2;
    public bool ox3;
    public bool ox4;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        puesto1 = MisionOxigeno.GetComponent<CompletarOxigeno>().oxi1;
        puesto2 = MisionOxigeno.GetComponent<CompletarOxigeno>().oxi2;
        puesto3 = MisionOxigeno.GetComponent<CompletarOxigeno>().oxi3;
        puesto4 = MisionOxigeno.GetComponent<CompletarOxigeno>().oxi4;

        if (ox1)
        {
            if (puesto1)
            {
                render = GetComponent<Renderer>();
                render.material.color = Nuevo;
                luz.color = Nuevo;

            }
            else
            {
                render = GetComponent<Renderer>();
                render.material.color = Default;
                luz.color = Default;
            }
        }

        if (ox2)
        {
            if (puesto2)
            {
                render = GetComponent<Renderer>();
                render.material.color = Nuevo;
                luz.color = Nuevo;
            }
            else
            {
                render = GetComponent<Renderer>();
                render.material.color = Default;
                luz.color = Default;
            }
        }

        if (ox3)
        {
            if (puesto3)
            {
                render = GetComponent<Renderer>();
                render.material.color = Nuevo;
                luz.color = Nuevo;
            }
            else
            {
                render = GetComponent<Renderer>();
                render.material.color = Default;
                luz.color = Default;
            }
        }

        if (ox4)
        {
            if (puesto4)
            {
                render = GetComponent<Renderer>();
                render.material.color = Nuevo;
                luz.color = Nuevo;
            }
            else
            {
                render = GetComponent<Renderer>();
                render.material.color = Default;
                luz.color = Default;
            }
        }
    }
}
