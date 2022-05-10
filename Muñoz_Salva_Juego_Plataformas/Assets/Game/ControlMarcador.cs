using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlMarcador : MonoBehaviour
{

    public GameManager gameManager;

    public Text Marcador_puntuacion;

    public Text Marcador_vidas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Marcador_puntuacion.text = "SCORE: " + gameManager.puntuacion;
        Marcador_vidas.text = "LIFES: " + gameManager.vidas;
    }
}
