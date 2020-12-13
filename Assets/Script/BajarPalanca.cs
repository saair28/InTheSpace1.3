using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BajarPalanca : MonoBehaviour
{
    public GameObject Fin;

    public GameObject Inicio;

    public float Endx;
    public float Endy;
    public float Endz;

    public float Startx;
    public float Starty;
    public float Startz;

    public bool Bajo;

    AreaSwitcher AreaSwitcher;

    public GameObject AreaActiva;

    public bool Completo;


    public bool activate1;

    public bool activate2;

    // Start is called before the first frame update
    void Start()
    {
        AreaSwitcher = AreaActiva.GetComponent<AreaSwitcher>();

        Endx = Fin.transform.position.x;

        Endy = Fin.transform.position.y;

        Endz = Fin.transform.position.z;

        Startx = Inicio.transform.position.x;

        Starty = Inicio.transform.position.y;

        Startz = Inicio.transform.position.z;
        activate1 = false;
        activate2 = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (AreaSwitcher.PlayerEnArea == true && Input.GetKeyDown(KeyCode.E) && Bajo == true && FindObjectOfType<ActivadoSwitcher1>().activate1 == false)
        {
            Vector3 Abajo = new Vector3(Endx, Endy, Endz);

            transform.position = Abajo;

            Bajo = false;

            Completo = true;

            Debug.Log("s");

           
        }

        else if (AreaSwitcher.PlayerEnArea == true && Input.GetKeyDown(KeyCode.E) && Bajo == false)
        {
            Vector3 Arriba = new Vector3(Startx, Starty, Startz);

            transform.position = Arriba;

            Bajo = true;

            Completo = false;

            
        }

        

    }
   
}
