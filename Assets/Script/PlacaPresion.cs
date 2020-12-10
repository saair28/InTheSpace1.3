using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacaPresion : MonoBehaviour
{
    public bool ispressed = false;

    public float x;

    public float y;

    public float z;

    public float restarY;

    public bool misionCompleta = false;

    public GameObject Hijo;


    void Start()
    {
        //rb = GetComponent<Rigidbody>();

        x = Hijo.transform.position.x;

        y = Hijo.transform.position.y;

        z = Hijo.transform.position.z;
    }

    void Update()
    {
        if (!ispressed)
        {
            Vector3 Arriba = new Vector3(x, y, z);

            Hijo.transform.position = Arriba;

            misionCompleta = false;
        }

        else if (ispressed)
        {
            Vector3 Abajo = new Vector3(x, y - restarY, z);

            Hijo.transform.position = Abajo;

            misionCompleta = true;
        }
    }

    public void Presionar()
    {
        ispressed = true;
    }

    public void Soltar()
    {
        ispressed = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Cubo"))
        {
            Presionar();
        }
    }
    /*
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Presionar();

            Debug.Log("das");
        }

        if (collision.gameObject.CompareTag("Cubo"))
        {
            Presionar();
        }
    }
    */
    private void OnTriggerExit(Collider other)
    {
        Soltar();
    }
    /*
    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.layer == LayerMask.NameToLayer("Player") )
        {
            Presionar();
        }
    }
    */
}


// -7.426799 80.39 30.9 ,    80.03
