using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegresoInicio : MonoBehaviour
{
    public float x;

    public float y;

    public float z;

    public bool regresar = false;

    // Start is called before the first frame update
    void Start()
    {
        x = transform.position.x;

        y = transform.position.y;

        z = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        Inicio();
    }


    public void Inicio()
    {
        if (regresar == true)
        {
            Vector3 regreso = new Vector3(x, y, z);

            transform.position = regreso;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "finDelMundo")
        {
            regresar = true;
        }
        if (other.tag == "Techo")
        {
            regresar = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "finDelMundo")
        {
            regresar = false;
        }
        if (other.tag == "Techo")
        {
            regresar = false;
        }
    }
}
