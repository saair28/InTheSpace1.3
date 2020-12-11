using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MisionPlacaDePresion : MonoBehaviour
{
   // public Player2 Player2;

    //public bool Sereproduce;

    public int cont = 0;

    public float cronometro = 0;

    public float Stop;

    public bool Ocupado = false;

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

       // Player2 = Player2.instance;

       // Sereproduce = Player2.GetComponent<Player2>().Sereproduce;

        if (FindObjectOfType<AudioManager>().IsPlaying("MisionPlacaDePresion") == true)
        {
            Debug.Log("sa");

            cronometro = cronometro + 1 * Time.deltaTime;

            Ocupado = true;
        }

        else
        {
            Ocupado = false;
        }

        if (cronometro >= Stop)
        {
            FindObjectOfType<AudioManager>().Pause("MisionPlacaDePresion");
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && cont <= 0 && verificar == false)
        {
            //FindObjectOfType<AudioManager>.pla
            FindObjectOfType<AudioManager>().Play("MisionPlacaDePresion");

            cont = cont + 1;
        }
    }
    /*
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            FindObjectOfType<AudioManager>().Pause("MisionPlacaDePresion");

        }
    }
    */
}
