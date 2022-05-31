using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameOver : MonoBehaviour
{

   void Start()
    {

    }

    void Update()
    {

    }

    public void joguedenovo()
    {
        if(MenuInicial.faseAtual == 1)
        {
            CameraController.lockCursor = true;
            StartCoroutine("fase1");
            Time.timeScale = 1;
            Config.PagNumero = 0;
        }
        if(MenuInicial.faseAtual == 2)
        {
            CameraController.lockCursor = true;
            StartCoroutine("fase2");
            Time.timeScale = 1;
            Config.PagNumero = 3;
        }
    }
    public void VoltaMenu()
    {
        StartCoroutine("VoltarMenu");
        Time.timeScale = 1;
    }

    public void SairDoJogo()
    {
        Application.Quit();
    }

    IEnumerator fase2()
    {
        yield return new WaitForSeconds(0.25f);
        UnityEngine.SceneManagement.SceneManager.LoadScene("Fase 2");
    }

    IEnumerator fase1()
    {
        yield return new WaitForSeconds(0.25f);
        UnityEngine.SceneManagement.SceneManager.LoadScene("Fase 1");
    }

    IEnumerator VoltarMenu()
    {
        yield return new WaitForSeconds(0.25f);
        UnityEngine.SceneManagement.SceneManager.LoadScene("Menu");
    }




}
