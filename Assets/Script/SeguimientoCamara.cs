using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguimientoCamara : MonoBehaviour
{
    public float velocidadSeguimientoCamara = 120.0f;

    public GameObject LocalizadorObj;

    Vector3 posicionSeguirdor;

    public float rotation = 1;

    public float clampAngle = 80.0f;

    public float inputSensitivity = 150.0f;

    public GameObject CamaraObj;
    public GameObject playerObj;
    public float camDistanceXToPlayer;
    public float camDistanceYToPlayer;
    public float camDistanceZToPlayer;
    public float mouseX;
    public float mouseY;
    public float finalInputX;
    public float finalInputZ;
    public float smoothX;
    public float smoothY;
    private float rotY = 0.0f;
    private float rotX = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 rot = transform.localRotation.eulerAngles;
        rotY = rot.y;
        rotX = rot.x;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("RightStickHorizontal");
        float inputZ = Input.GetAxis("RightStickVertical");
        mouseX = Input.GetAxis("Mouse X") * rotation;
        mouseY = Input.GetAxis("Mouse Y") * rotation ;
        finalInputX = inputX + mouseX;
        finalInputZ = inputZ + mouseY;

        rotY += finalInputX * inputSensitivity * Time.deltaTime;
        rotY += finalInputZ * inputSensitivity * Time.deltaTime;

        rotX = Mathf.Clamp (rotX, -clampAngle, clampAngle);

        Quaternion localRotation = Quaternion.Euler (rotX, rotY, 0.0f);
        transform.rotation = localRotation;


        camaraUpdate();
    }

    void camaraUpdate()
    {

        Transform target = LocalizadorObj.transform;

        float step = velocidadSeguimientoCamara * Time.deltaTime;

        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
    } 

}
