using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RestartPosition : MonoBehaviour
{
    public float limitY = 0f;

    private Vector3 startPos;

    public GameManager gameManager;

    public int numvidas = 1;

    // Use this for initialization
    void Start()
    {
        SetStartPos();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (transform.position.y < limitY)
        {
            gameManager.vidas -= numvidas;
            ResetPosition();
            //Debug.Log("Restart to " + transform.position);
        }
    }

    public void SetStartPos()
    {
        startPos = transform.position;
    }

    public void ResetPosition()
    {
        transform.position = startPos;
    }
}

