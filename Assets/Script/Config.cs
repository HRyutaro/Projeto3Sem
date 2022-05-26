using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Config : MonoBehaviour
{
    //gravidade
    public float GravityMULT;

    //pause
    public GameObject Pause;

    void Start()
    {
        //gravidade
        Physics.gravity = Vector3.down * 9.81f * GravityMULT;
    }

    void Update()
    {
        //pause
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(Time.timeScale == 1)
            {
                Pause.SetActive(true);
                CameraController.lockCursor = false;
                Time.timeScale = 0;
            }
            else if(Time.timeScale == 0)
            {
                Pause.SetActive(false);
                CameraController.lockCursor = true;
                Time.timeScale = 1;
            }

        }

    }

    //Botões
    public void Resume()
    {
        CameraController.lockCursor = true;
        Time.timeScale = 1;
        Pause.SetActive(false);
    }
    
}
