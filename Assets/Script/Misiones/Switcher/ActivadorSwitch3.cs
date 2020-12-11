using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivadorSwitch3 : MonoBehaviour
{
    public GameObject AreaActiva;
    AreaSwitcher AreaSwitcher;
    public Transform startMark;
    public Transform endMark;
    public bool ActivarSwitch;
    public float contador;
    // Start is called before the first frame update
    void Start()
    {
        contador = 0f;
        ActivarSwitch = false;
        AreaSwitcher = AreaActiva.GetComponent<AreaSwitcher>();
    }

    // Update is called once per frame
    void Update()
    {
        if (FindObjectOfType<SwitcherManager>().ganaste == false)
        {
            if (AreaSwitcher.PlayerEnArea == true && FindObjectOfType<StartMark>().inmunity1 == false || FindObjectOfType<EndMark>().inmunity2 == false)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    ActivarSwitch = true;
                }
            }
            else
            {
                ActivarSwitch = false;
                contador = 0;
            }
            if (AreaSwitcher.PlayerEnArea == true && ActivarSwitch == true && FindObjectOfType<StartMark>().inmunity1 == false || FindObjectOfType<EndMark>().inmunity2 == false)
            {
                contador = contador + Time.deltaTime / 5f;
                this.transform.position = Vector3.Lerp(startMark.position, endMark.position, contador);
                ActivarSwitch = false;


            }
            else
            {
                contador = 0;
            }

            if (AreaSwitcher.PlayerEnArea == true && ActivarSwitch == true && FindObjectOfType<StartMark>().inmunity1 == false || FindObjectOfType<EndMark>().inmunity2 == false && FindObjectOfType<EndMark>().Switch3EnEndMark)
            {
                contador = contador + Time.deltaTime / 5f;
                this.transform.position = Vector3.Lerp(endMark.position, startMark.position, contador);
                ActivarSwitch = false;
            }
            else
            {
                contador = 0;
            }
            
        }
    }
}
