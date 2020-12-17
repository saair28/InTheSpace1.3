using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controlador : MonoBehaviour
{
    public Modelo modelo;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {



    }

    public void Sujetar()
    {
        if (modelo.Manos != null && modelo.Manos.GetComponent<Agarrar>().Sujetar == true && modelo.Agarra == null)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                modelo.Agarra = modelo.Manos;

                modelo.Agarra.GetComponent<Agarrar>().Sujetar = false;

                modelo.Agarra.transform.parent = modelo.ZoneInteraction.transform;

                //Agarra.GetComponent<Collider>().enabled = false;

                // this.transform.parent = ZoneInteraction.transform;

                // Agarra.transform.position = ZoneInteraction.position;

                modelo.Agarra.GetComponent<Rigidbody>().useGravity = false;

                modelo.Agarra.GetComponent<Rigidbody>().isKinematic = true;



                modelo.loToma = true;

                modelo.LoSujeta = true;

            }
        }

        else if (modelo.Agarra != null)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                modelo.Agarra.GetComponent<Agarrar>().Sujetar = true;

                modelo.Agarra.transform.parent = null;

                this.transform.parent = null;

                //Agarra.GetComponent<Collider>().enabled = true;

                modelo.Agarra.GetComponent<Rigidbody>().useGravity = true;

                modelo.Agarra.GetComponent<Rigidbody>().isKinematic = false;

                modelo.Agarra = null;

                modelo.loToma = false;

                modelo.LoSujeta = false;

            }
        }
    }

    public void Move()
    {
        modelo.isGrounded = Physics.CheckSphere(modelo.groundCheck.position, modelo.groundDistance, modelo.groundMask);

        if (modelo.isGrounded && modelo.velocity.y < 0)
        {
            modelo.velocity.y = -2f;
        }

        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        modelo.velocity.y += modelo.gravity * Time.deltaTime;

        modelo.controller.Move(modelo.velocity * Time.deltaTime);

        if (direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + modelo.cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref modelo.turnSmoothVelocity, modelo.turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;

            modelo.controller.Move(moveDir.normalized * modelo.speed * Time.deltaTime);
        }

        if (Input.GetButtonDown("Jump") && modelo.isGrounded)
        {
            modelo.velocity.y = Mathf.Sqrt(modelo.jumpHeight * -2f * modelo.gravity);
            Debug.Log("JUMP");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Win")
        {
            modelo.Nivel2.SetActive(true);
            modelo.Luz1.SetActive(false);
            modelo.Luz2.SetActive(true);
            modelo.JugadorEnScena = false;
        }
        /* if (other.gameObject.CompareTag("Audios"))
         {
             Sereproduce = true;
         }
        */
    }

}
