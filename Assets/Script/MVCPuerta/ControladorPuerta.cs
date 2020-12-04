using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ControladorPuerta : MonoBehaviour
{
    
   public ModeloPuerta modelo;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SeAbrira()
    {
        if (modelo.AreaDeActivacion.playerEnArea == true)
        {
            modelo.AreaDeActivacion.playerSalioDelArea = false;
            //contador = 0;
            modelo.contador = modelo.contador + Time.deltaTime / 5;
            //float distCovered = (Time.time - startTime) * speed;
            //transform.position = Vector3.Lerp(point1.position, point2.position, distCovered / journeyLength);
            this.transform.position = Vector3.Lerp(modelo.point1.position, modelo.point2.position, modelo.contador);
        }
        if (modelo.AreaDeActivacion.playerSalioDelArea == true)
        {
            modelo.AreaDeActivacion.playerEnArea = false;
            modelo.contador = 0;
            modelo.contador = modelo.contador + Time.deltaTime / 5;
            this.transform.position = Vector3.Lerp(transform.position, modelo.point1.position, modelo.contador);
        }
    }
}