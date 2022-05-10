using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public int puntuacion = 0;

    public int vidas = 0;

    public int nummonedas = 0;

    // public GameObject Canvas_Derrota;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (vidas <= 0)
        {
            SceneManager.LoadScene("Final");
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene("Inicio");
    }
}
