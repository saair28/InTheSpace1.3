using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Modelo : MonoBehaviour
{
    public static Modelo instance;

    public float saltoFuerza = 5.0f;

    public bool salto = false;

    public bool LoSujeta;

    //public bool Sereproduce = false;

    public GameObject Nivel2;

    public GameObject Luz1;

    public GameObject Luz2;

    public GameObject Manos;

    public GameObject Agarra;

    public Transform ZoneInteraction;

    public bool loToma = false;

    public bool deteccionSuelo = false;

    //public Rigidbody rb;

    public Transform cam;

    public CharacterController controller;

    public float speed = 6f;

    public float turnSmoothTime = 0.1f;

    public float turnSmoothVelocity;

    public float gravity = -9.81f;
    public bool JugadorEnScena;
    public Vector3 velocity;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    public bool a;

    public bool isGrounded;

    public float jumpHeight = 3f;

    public GameObject Nucleo;

    public float Secae;

    public int s = 0;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        JugadorEnScena = true;
        //FindObjectOfType<AudioManager>().Play("Tutorial1");
        FindObjectOfType<AudioManager>().Play("Tutorial1");
        FindObjectOfType<AudioManager>().Play("AudioFondo");
    }

    // Update is called once per frame
    void Update()
    {

    }

}
