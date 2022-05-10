using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirObjeto : MonoBehaviour
{

    public GameObject objetivo;

    private Vector3 offset;



    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - objetivo.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = objetivo.transform.position + offset;
    }
}
