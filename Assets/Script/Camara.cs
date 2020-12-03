using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    public float distanciaMin = 1.0f;
    public float distanciaMax = 4.0f;
    public float sombra = 10.0f;
    Vector3 dolloir;
    public Vector3 dollyoirAdjusted;
    public float distance;
    // Start is called before the first frame update
    void awake()
    {
        dolloir = transform.localPosition.normalized;

        distance = transform.localPosition.magnitude;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 desiredCamaraPosi = transform.parent.TransformPoint(dolloir * distanciaMax);

        RaycastHit hit;

        if (Physics.Linecast(transform.parent.position, desiredCamaraPosi, out hit))
        {
            distance = Mathf.Clamp(hit.distance, distanciaMin, distanciaMax);
        }

        else
        {
            distance = distanciaMax;
        }
        transform.localPosition = Vector3.Lerp(transform.localPosition, dolloir * distance, Time.deltaTime * sombra);
    }
}
