using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boton_Pausa : MonoBehaviour
{
    public void Pausa()
    {
        SceneManager.LoadScene("Pausa", LoadSceneMode.Additive);
    }
}
