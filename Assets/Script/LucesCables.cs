using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LucesCables : MonoBehaviour
{
    public Color Rojo;
    public Color Verde;
    public Renderer render;
    public Light luz;

    public GameObject Luces;
    public bool Completo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Completo = Luces.GetComponent<Circle>().Verde;

        if (Completo)
        {
            render = GetComponent<Renderer>();
            render.material.color = Verde;
            luz.color = Verde;
        }
        else
        {
            render = GetComponent<Renderer>();
            render.material.color = Rojo;
            luz.color = Rojo;
        }
    }
}
