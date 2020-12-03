using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AleatorioUbicacion : MonoBehaviour
{
    public GameObject parteNucleo;

    // Start is called before the first frame update
    void Start()
    {
        LugarCreacion();
    }

    public void LugarCreacion()
    {
        Vector3 spawnNucleo = new Vector3(Random.Range(-12, 12), 0.9f, Random.Range(-12, -1));

        Instantiate(parteNucleo, spawnNucleo, transform.rotation);
    }
}
