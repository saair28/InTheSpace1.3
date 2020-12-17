using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivadoSwitcher1 : MonoBehaviour
{
    /*
    public GameObject AreaActiva;
    AreaSwitcher AreaSwitcher;
    public Transform startMark;
    public Transform endMark;
    public bool ActivarSwitch;
    public float contador;*/
    public bool activate1;
    //public bool activateStart;
    public float Endx;
    public float Endy;
    public float Endz;

    public float Startx;
    public float Starty;
    public float Startz;
    public GameObject Fin;

    public bool Verde;

    public bool Roja;

    public bool resolucionPuzzle;

    public GameObject Inicio;

    // Start is called before the first frame update
    void Start()
    {/*
        contador = 0f;
        ActivarSwitch = false;
        AreaSwitcher = AreaActiva.GetComponent<AreaSwitcher>();*/
        activate1 = false;
        //activateStart = false;
        Endx = Fin.transform.position.x;

        Endy = Fin.transform.position.y;

        Endz = Fin.transform.position.z;

        Startx = Inicio.transform.position.x;

        Starty = Inicio.transform.position.y;

        Startz = Inicio.transform.position.z;
        resolucionPuzzle = false;

        Roja = true;

    }

    // Update is called once per frame
    void Update()
    {/*
        if (FindObjectOfType<SwitcherManager>().ganaste == false)
        {
            if (AreaSwitcher.PlayerEnArea == true) //&& FindObjectOfType<StartMark>().inmunity1 == false || FindObjectOfType<EndMark>().inmunity2 == false)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    ActivarSwitch = true;
                }
            } else
            {
                ActivarSwitch = false;
                contador = 0;
            }

            if (AreaSwitcher.PlayerEnArea == true && ActivarSwitch == true )//&& FindObjectOfType<StartMark>().inmunity1 == false || FindObjectOfType<EndMark>().inmunity2 == false)
            {
                contador = contador + Time.deltaTime / 5f;
                this.transform.position = Vector3.Lerp(startMark.position, endMark.position, contador);
                ActivarSwitch = false;
                
            }
            else
            {
                contador = 0;
            }
            if (AreaSwitcher.PlayerEnArea == true && ActivarSwitch == true && FindObjectOfType<EndMark>().Switch1EnEndMark)// && FindObjectOfType<StartMark>().inmunity1 == false || FindObjectOfType<EndMark>().inmunity2 == false && FindObjectOfType<EndMark>().Switch1EnEndMark)
            {
                contador = contador + Time.deltaTime / 5f;
                this.transform.position = Vector3.Lerp(endMark.position, startMark.position, contador);
                ActivarSwitch = false;
            }
            else
            {
                contador = 0;
            }
            
            if (FindObjectOfType<EndMark>().Switch2EnEndMark == true)
            {
                contador = contador + Time.deltaTime / 5f;
                this.transform.position = Vector3.Lerp(endMark.position, startMark.position, contador);
            }
            else
            {
                contador = 0;
            }

        } 
        */

        /*
        if (FindObjectOfType<ActivadorSwitcher2>().activate2 == true)
        {
            Vector3 Abajo = new Vector3(Endx, Endy, Endz);

            transform.position = Abajo;
        } /*else if (FindObjectOfType<ActivadorSwitcher2>().activate2 == false)
        {
            Vector3 Arriba = new Vector3(Startx, Starty, Startz);

            transform.position = Arriba;
        }*/

    }

    public void OnTriggerEnter(Collider other)
    {
        if(resolucionPuzzle == false)
        { 
            if (other.tag == "end1")
            {
                Debug.Log("sasfkjh");
                activate1 = true;

                
            }
        }

        if (other.tag == "end1")
        {

            Verde = true;
            Roja = false;
        }

        /*
        if (other.tag == "start1")
        {
            activateStart = true;
        }else
        {
            activateStart = false;
        }*/

    }
    public void OnTriggerExit(Collider other)
    {
        if (resolucionPuzzle == false)
        {
            if (other.tag == "end1")
            {
                Debug.Log("sasfkjh");
                activate1 = false;
            }
        }

        if (other.tag == "end1")
        {
            Verde = false;
            Roja = true;
        }
    }
    
}
