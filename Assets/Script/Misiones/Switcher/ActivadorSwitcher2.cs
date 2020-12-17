using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivadorSwitcher2 : MonoBehaviour
{/*
    public GameObject AreaActiva;
    AreaSwitcher AreaSwitcher;
    public Transform startMark;
    public Transform endMark;
    public bool ActivarSwitch;
    public float contador;*/
    // Start is called before the first frame update
    public bool activate2;
    public float Endx;
    public float Endy;
    public float Endz;

    public float Startx;
    public float Starty;
    public float Startz;
    public GameObject Fin;
    public GameObject palanca1;

    public bool Verde;
    public bool Rojo;
    public bool Amarillo;
    public bool activity1;

    public GameObject Inicio;
    void Start()
    {/*
        contador = 0f;
        ActivarSwitch = false;
        AreaSwitcher = AreaActiva.GetComponent<AreaSwitcher>();*/
        activate2 = false;
        
        Endx = Fin.transform.position.x;

        Endy = Fin.transform.position.y;

        Endz = Fin.transform.position.z;

        Startx = Inicio.transform.position.x;

        Starty = Inicio.transform.position.y;

        Startz = Inicio.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        activity1 = palanca1.GetComponent<ActivadoSwitcher1>().activate1;

        if (activity1)
        {
            Amarillo = true;
            Verde = false;
            Rojo = false;
        }
        else
        {
            Amarillo = false;
            Rojo = true;
        }
        /*
        if (FindObjectOfType<SwitcherManager>().ganaste == false)
        {
            if (AreaSwitcher.PlayerEnArea == true )//&& FindObjectOfType<StartMark>().inmunity1 == false || FindObjectOfType<EndMark>().inmunity2 == false)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    ActivarSwitch = true;
                }
            }
            else
            {
                ActivarSwitch = false;
                contador = 0;
            }

            if (AreaSwitcher.PlayerEnArea == true && ActivarSwitch == true) //&& FindObjectOfType<StartMark>().inmunity1 == false || FindObjectOfType<EndMark>().inmunity2 == false)
            {
                contador = contador + Time.deltaTime / 5f;
                this.transform.position = Vector3.Lerp(startMark.position, endMark.position, contador);
                ActivarSwitch = false;

            }
            else
            {
                contador = 0;
            }
            if (AreaSwitcher.PlayerEnArea == true && ActivarSwitch == true && FindObjectOfType<EndMark>().Switch2EnEndMark) //&& FindObjectOfType<StartMark>().inmunity1 == false || FindObjectOfType<EndMark>().inmunity2 == false && FindObjectOfType<EndMark>().Switch2EnEndMark)
            {
                contador = contador + Time.deltaTime / 5f;
                this.transform.position = Vector3.Lerp(endMark.position, startMark.position, contador);
                ActivarSwitch = false;
            }
            else
            {
                contador = 0;
            }
            
            if (FindObjectOfType<EndMark>().Switch1EnEndMark == true)
            {
                contador = contador + Time.deltaTime / 5f;
                this.transform.position = Vector3.Lerp(endMark.position, startMark.position, contador);
            }
            else
            {
                contador = 0;
            }
            if (FindObjectOfType<EndMark>().Switch3EnEndMark)
            {
                contador = contador + Time.deltaTime / 5f;
                this.transform.position = Vector3.Lerp(startMark.position, endMark.position, contador);
                ActivarSwitch = false;
            }
            else
            {
                contador = 0;
            }
        }*//*
        if (FindObjectOfType<ActivadoSwitcher1>().activate1 == false)
        {
            Vector3 Abajo = new Vector3(Endx, Endy, Endz);

            transform.position = Abajo;
        }/*
        /*else*/
        if (FindObjectOfType<ActivadoSwitcher1>().resolucionPuzzle == false)
        { 
            if (/*FindObjectOfType<ActivadoSwitcher1>().activateStart == true &&*/ FindObjectOfType<AreaSwitcher>().PlayerEnArea == false &&  FindObjectOfType<ActivadoSwitcher1>().activate1 == true)
            {
                Vector3 Arriba = new Vector3(Startx, Starty, Startz);

                transform.position = Arriba;

                //FindObjectOfType<BajarPalanca>().Bajo = true;

               // FindObjectOfType<BajarPalanca>().Completo = false;
            }
        }
    }
/*
    public void OnTriggerEnter(Collider other)
    {
        if (Amarillo == false)
        {
            if (other.tag == ("start2"))
            {
                Rojo = true;
                Verde = false;
            }

            if (other.tag == ("end2"))
            {
                //luz verde;
                Verde = true;
                Rojo = false;
            }
        }
    }
*/
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "end2")
        {
           

            //luz verde
            Verde = true;
            Rojo = false;
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "end2")
        {
          

            //luz roja
            Verde = false;
            Rojo = true;
        }
    }
    /*
        public void OnTriggerExit(Collider other)
        {
            if (other.tag == ("end2"))
            {
                //luz verde;
                Verde = false;
                Rojo = true;
            }
        }
        /*
        public void OnTriggerStay(Collider other)
        {
            if (other.tag == "end2")
            {
                Debug.Log("sasfkjh");
                activate2 = true;
            }
            else
            {
                activate2 = false;
            }

        }*/
}
