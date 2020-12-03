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

    public bool m1;
    public bool m2;
    public bool m3;

    public bool m4;
    public bool m5;

    public bool m6;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PasaASiguienteNivel();
        m1 = mision1.GetComponent<Cables>().prenderLuces;
        m2 = mision2.GetComponent<AreaDeAccionamiento>().misionCUMPLIDA;
        m3 = mision3.GetComponent<CompletarOxigeno>().misionCompleta;

        m4 = mision4.GetComponent<Cables>().prenderLuces;
        m5 = true;//mision5.GetComponent<PlacaPresion>().misionCompleta;

        m6 = mision6.GetComponent<CabinaOxigeno>().misionCumplida;
    }

    public void PasaASiguienteNivel()
    {
        if (m1==true && m2 == true && m3 == true)
        {
            puerta1.SetActive(false);
            puerta2.SetActive(false);
        }

        if (m4 && m5)
        {
            puerta3.SetActive(false);
        }

        if (m6)
        {
            SceneManager.LoadScene("Victoria");
        }
    }
}

