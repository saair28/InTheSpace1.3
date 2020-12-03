using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Luces : MonoBehaviour
{
    Light miLuz;

    public bool estaArreglado;

    public GameObject Cable;

    public Coroutine parpadeo;

    // Start is called before the first frame update
    void Start()
    {
        miLuz = GetComponent<Light>();

       parpadeo = StartCoroutine(ParpadeoLuz());
    }

    // Update is called once per frame
    void Update()
    {

        estaraRoto();

    }

    public void estaraRoto()
    {
        estaArreglado = Cable.GetComponent<Cables>().prenderLuces;

        if(estaArreglado == true && parpadeo != null)
        {
            StopCoroutine(parpadeo);

            parpadeo = null;

            miLuz.intensity = 1;
        }
    }

    public IEnumerator ParpadeoLuz()
    {
        while (true)
        {
            miLuz.intensity = 0.6f;

            yield return new WaitForSeconds(1);

            miLuz.intensity = 0.2f;

            yield return new WaitForSeconds(1);
        }
    }
}
