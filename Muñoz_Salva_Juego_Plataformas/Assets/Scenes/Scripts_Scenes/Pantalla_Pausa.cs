using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pantalla_Pausa : MonoBehaviour
{
    public void Continuar()
    {
        SceneManager.UnloadSceneAsync("Pausa");
    }

    public void Inicio()
    {
        SceneManager.LoadScene("Inicio");
    }
}
