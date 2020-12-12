using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComprobadorPalanca : MonoBehaviour
{
    public GameObject palanca1;

    public GameObject palanca2;

    public GameObject palanca3;

    public bool palan1;

    public bool palan2;

    public bool palan3;

    public bool ganaste;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        palan1 = palanca1.GetComponent<BajarPalanca>().Completo;


        palan2 = palanca2.GetComponent<BajarPalanca>().Completo;


        palan3 = palanca3.GetComponent<BajarPalanca>().Completo;

        gano();
    }

    public void gano()
    {
        if (palan1 && palan2 && palan3)
        {
            ganaste = true;
        }
        else
        {
            ganaste = false;
        }
    }
}
