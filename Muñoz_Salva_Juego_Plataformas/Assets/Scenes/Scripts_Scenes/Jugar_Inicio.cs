using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jugar_Inicio : MonoBehaviour
{
    public void Jugar()
    {
        SceneManager.LoadScene("Juego");
    }
}
