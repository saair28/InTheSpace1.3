using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompletarOxigeno : MonoBehaviour
{
    public GameObject oxigeno1;
    public GameObject oxigeno2;
    public GameObject oxigeno3;
    public GameObject oxigeno4;

    public bool oxi1;
    public bool oxi2;
    public bool oxi3;
    public bool oxi4;
    public bool misionCompleta;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        oxi1 = oxigeno1.GetComponent<CabinaOxigeno>().misionCumplida;
        oxi2 = oxigeno2.GetComponent<CabinaOxigeno>().misionCumplida;
        oxi3 = oxigeno3.GetComponent<CabinaOxigeno>().misionCumplida;
        oxi4 = oxigeno4.GetComponent<CabinaOxigeno>().misionCumplida;
        confirmacionDeMisionOxigeno();
    }

    public void confirmacionDeMisionOxigeno()
    {
        if(oxi1 == true && oxi2 == true && oxi3 == true && oxi4 == true)
        {
            misionCompleta = true;
        }
    }
}
