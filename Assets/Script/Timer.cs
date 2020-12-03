using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer : MonoBehaviour
{
    public float tiempo;

    public TextMeshProUGUI VerTiempo;


    public float PonerTiempo;

    public float T;

    // Start is called before the first frame update
    void Start()
    {
        PonerTiempo = tiempo;
    }

    // Update is called once per frame
    void Update()
    {
        T -= Time.deltaTime;

        float t = T - tiempo;

        if (t >= 1)
        {

            string Minutos = ((int)t / 60).ToString();

            string Segundos = (t % 60).ToString("f0");

            VerTiempo.text = Minutos + ":" + Segundos;
        }

        else if (t <= 0)
        {
            T = 0;

            tiempo = PonerTiempo;

            Escena();
        }
    }

    public void Escena()
    {
        SceneManager.LoadScene("Derrota");
    }
}
