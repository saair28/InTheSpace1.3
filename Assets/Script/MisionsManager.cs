using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MisionsManager : MonoBehaviour
{
    public GameObject mision1;
    public GameObject mision2;
    public GameObject mision3;

    public GameObject mision4;
    public GameObject mision5;


    public GameObject mision6;

    public GameObject puerta1;
    public GameObject puerta2;

    public GameObject puerta3;

    public bool sonido1 = false;
    public bool sonido2 = false;
    public bool sonido3 = false;

    public bool m1;
    public bool m2;
    public bool m3;

    public bool m4;
    public bool m5;

    public bool m6;

    public ControladorAudio controlador;

    public bool verificar = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        controlador = ControladorAudio.instance;

        verificar = controlador.GetComponent<ControladorAudio>().alto;

        PasaASiguienteNivel();
        m1 = mision1.GetComponent<Cables>().prenderLuces;
        m2 = mision2.GetComponent<ComprobadorPalanca>().ganaste;
        m3 = mision3.GetComponent<CompletarOxigeno>().misionCompleta;

        m4 = mision4.GetComponent<Cables>().prenderLuces;
        m5 = mision5.GetComponent<PlacaPresion>().misionCompleta;

        m6 = mision6.GetComponent<CabinaOxigeno>().misionCumplida;
    }

    public void PasaASiguienteNivel()
    {
        if (m1 == true && m2 == true && m3 == true)
        {
            puerta1.SetActive(false);
            puerta2.SetActive(false);
            if (sonido1 == false && verificar == false)
            {
                FindObjectOfType<AudioManager>().Play("MisionesNivel1Completadas");
                sonido1 = true;
            }

        }

        else
        {
            puerta1.SetActive(true);
            puerta2.SetActive(true);
        }

        if (m4 && m5)
        {
            puerta3.SetActive(false);
            if (sonido2 == false && verificar == false)
            {
                FindObjectOfType<AudioManager>().Play("MisionesNivel2Completadas");
                sonido2 = true;
            }
        }
        else
        {
            puerta3.SetActive(true);
        }


        if (m6)
        {
            SceneManager.LoadScene("Victoria");
            if(sonido3 == false)
            {
                FindObjectOfType<AudioManager>().Play("Ganaste");
                sonido3 = true;
            }
        }
    }
}

