using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroduccionPlanta2 : MonoBehaviour
{
    public Player2 Player2;

    public bool Sereproduce;

    public int cont = 0;

    //public float cronometro = 0;

    // public float Stop;

    // public bool Ocupado = false;

    // public ControladorAudio controlador;

    //public bool vericar = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // controlador = ControladorAudio.instance;

        // vericar = controlador.GetComponent<ControladorAudio>().alto;

        Player2 = Player2.instance;

        Sereproduce = Player2.GetComponent<Player2>().Sereproduce;
        /*
                if (cont == 1)
                {
                    cronometro = cronometro + 1 + Time.deltaTime;
                }

                if (cronometro <= Stop)
                {
                    Ocupado = false;
                }

                else
                {
                    Ocupado = true;
                }
        */
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && Sereproduce == false && cont <= 0)
        {
            //FindObjectOfType<AudioManager>.pla
            FindObjectOfType<AudioManager>().Play("IntroduccionPlanta2Audio");

            cont = cont + 1;
        }
    }
    /*
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            FindObjectOfType<AudioManager>().Pause("IntroduccionPlanta2Audio");

        }
    }
    */
}
