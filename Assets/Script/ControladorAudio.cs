using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorAudio : MonoBehaviour
{
    public static ControladorAudio instance;

    public GameObject Audio1;
    public GameObject Audio2;
    public GameObject Audio3;
    public GameObject Audio4;
    public GameObject Audio5;
    public GameObject Audio6;
    public GameObject Audio7;
    public GameObject Audio8;
    public GameObject Audio9;

    public bool aud1;
    public bool aud2;
    public bool aud3;
    public bool aud4;
    public bool aud5;
    public bool aud6;
    public bool aud7;
    public bool aud8;
    public bool aud9;

    public bool alto;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {/*
        aud1 = Audio1.GetComponent<MisionCable>().Ocupado;

        aud2 = Audio2.GetComponent<MisionPalanca>().Ocupado;
        aud3 = Audio3.GetComponent<MisionOxigeno>().Ocupado;
        aud4 = Audio4.GetComponent<MisionCable>().Ocupado;
        aud5 = Audio5.GetComponent<MisionPlacaDePresion>().Ocupado;
        aud6 = Audio6.GetComponent<IntroduccionPlanta1>().Ocupado;
        aud7 = Audio7.GetComponent<IntroduccionPlanta2>().Ocupado;
        aud8 = Audio8.GetComponent<IntroduccionFinal>().Ocupado;
        aud9 = Audio9.GetComponent<MisionNucleoAudio>().Ocupado;
        Verificador();
        */
    }

    public void Verificador()
    {
        if (aud1 == true )
        {
            alto = true;
        }
        else
        {
            alto = false;
        }
    }
}
