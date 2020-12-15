using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puertas : MonoBehaviour
{
    public GameObject AreaActiva;
    ActivadorPuerta AreaDeActivacion;
    public Transform point1;
    public Transform point2;
    //private float startTime;
    //public float speed;
    //public float journeyLength = 1.0f;
    public float contador = 0f;
    public GameObject audioTuTorial;
    public bool abrir;
    public bool puertaTutorial;

    

    // Start is called before the first frame update
    void Start()
    {
        AreaDeActivacion = AreaActiva.GetComponent<ActivadorPuerta>();
    }

    // Update is called once per frame
    void Update()
    {
        if (puertaTutorial == true)
        {
            abrir = audioTuTorial.GetComponent<AudioManager>().abrir;

            if (abrir == true)
            {

                if (AreaDeActivacion.playerEnArea == true)
                {
                    AreaDeActivacion.playerSalioDelArea = false;
                    contador = contador + Time.deltaTime;
                   
                }
                if (AreaDeActivacion.playerSalioDelArea == true)
                {
                    AreaDeActivacion.playerEnArea = false;
                    contador = contador - Time.deltaTime;
                    
                }
                if (contador > 1)
                {
                    contador = 1;
                }
                else if (contador < 0)
                {
                    contador = 0;
                }
                this.transform.position = Vector3.Lerp(point1.position, point2.position, contador);
                
            }
        }


        else
        {
            if (AreaDeActivacion.playerEnArea == true)
            {
                AreaDeActivacion.playerSalioDelArea = false;
                contador = contador + Time.deltaTime;
                
            }
            if (AreaDeActivacion.playerSalioDelArea == true)
            {
                AreaDeActivacion.playerEnArea = false;
                contador = contador - Time.deltaTime;
                
            }
            if (contador > 1)
            {
                contador = 1;
            }
            else if (contador < 0)
            {
                contador = 0;
            }
            this.transform.position = Vector3.Lerp(point1.position, point2.position, contador);
        }

        
    }

    
}
