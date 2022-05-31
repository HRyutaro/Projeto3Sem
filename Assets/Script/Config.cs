using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Config : MonoBehaviour
{
    //gravidade
    public float GravityMULT;

    //pause
    public GameObject Pause;

    //Numero de pags
    public GameObject[] NdePags;
    public static int PagNumero = 0; 

    void Start()
    {
        //Numero de pags
        NdePags[0].SetActive(true);
        //gravidade
        Physics.gravity = Vector3.down * 9.81f * GravityMULT;
    }

    void Update()
    {
        if (PagNumero == 6)
        {
            StartCoroutine("FimDeJogo");
        }

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
        if(PagNumero == 1)
        {
            NdePags[0].SetActive(false);
            NdePags[1].SetActive(true);
        }
        if (PagNumero == 2)
        {
            NdePags[1].SetActive(false);
            NdePags[2].SetActive(true);
        }
        if (PagNumero == 3)
        {
            NdePags[2].SetActive(false);
            NdePags[3].SetActive(true);
        }

    }

    IEnumerator FimDeJogo()
    {
        yield return new WaitForSeconds(1f);
        UnityEngine.SceneManagement.SceneManager.LoadScene("FimDeJogo");
    }

    //Botões
    public void Resume()
    {
        CameraController.lockCursor = true;
        Time.timeScale = 1;
        Pause.SetActive(false);
    }

    
}
