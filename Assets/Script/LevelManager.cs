using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public bool niveltrue;
    public GameObject Nivel1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (niveltrue == true)
        {
            Nivel1spawn();
        }
        else
        {
            //Destroy(Nivel1);
        }
    }

    public void Nivel1spawn()
    {
        Instantiate(Nivel1, transform.position, transform.rotation);
        niveltrue = false;
    }
}
