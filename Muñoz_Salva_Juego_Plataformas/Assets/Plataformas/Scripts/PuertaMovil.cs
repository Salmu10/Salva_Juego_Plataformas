using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuertaMovil : MonoBehaviour
{

    public float velocidad = 3f;

    public Transform puntoA;

    public Transform puntoB;

    private Transform siguientePunto;


    // Start is called before the first frame update
    void Start()
    {
        transform.position = puntoA.transform.position;
        siguientePunto = puntoB;
    }

    // Update is called once per frame
    void Update()
    {
        float paso = velocidad * Time.deltaTime;
        if (Vector3.Distance(transform.position, siguientePunto.position) > paso)
        {
            transform.position = Vector3.MoveTowards(transform.position, siguientePunto.position, paso);
        }
        else
        {
            transform.position = siguientePunto.position;
            if (siguientePunto == puntoA)
            {
                siguientePunto = puntoB;
            }
            else
            {
                siguientePunto = puntoA;
            }
        }
    }
}
