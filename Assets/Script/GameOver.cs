using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameOver : MonoBehaviour
{
   public static int faseAtual;

   void Start()
    {

    }

    void Update()
    {

    }

    public void joguedenovo()
    {
        if(faseAtual == 1)
        {
            StartCoroutine("fase1");
            Time.timeScale = 1;
        }
        if(faseAtual == 2)
        {
            StartCoroutine("fase2");
            Time.timeScale = 1;
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
