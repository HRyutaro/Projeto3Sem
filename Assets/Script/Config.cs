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
                Cursor.visible = true;
                Pause.SetActive(true);
                Time.timeScale = 0;
            }
            else
            {
                Pause.SetActive(false);
                Time.timeScale = 1;
                Cursor.visible = false;
            }

        }
    }
}
