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

    public GameObject Manos;

    public GameObject Agarra;

    public Transform ZoneInteraction;

    public bool loToma = false;
}
