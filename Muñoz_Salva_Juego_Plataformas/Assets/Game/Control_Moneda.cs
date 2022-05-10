using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control_Moneda : MonoBehaviour
{

    public int puntos = 100;

    public GameManager gameManager;

    public GameObject fx;

    // Start is called before the first frame update
    void Start()
    {
        gameManager.nummonedas++;
    }

    // Update is called once per frame
    private void Update()
    {
        transform.Rotate(30 * Time.deltaTime, 60 * Time.deltaTime, 0 * Time.deltaTime);
    }

    /*
    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("Hemos Chocado!!!!");
        Destroy(gameObject);
    }
    */

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Debug.Log("Has conseguido " + puntos + "puntos!");
        gameManager.puntuacion += puntos;
        gameManager.nummonedas--;
        Instantiate(fx, transform.position, Quaternion.identity);
    }
}
