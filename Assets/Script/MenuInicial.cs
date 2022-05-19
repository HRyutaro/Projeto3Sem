using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuInicial : MonoBehaviour
{
    public static int faseAtual;
    public GameObject continuar; 
    void Start()
    {
        if (faseAtual > 1)
        {
            continuar.SetActive(true);
        }
    }

    void Update()
    {

    }

    public void Continuar()
    {
        if (faseAtual == 2)
        {
            StartCoroutine("fase2");
        }
    }


    public void NovoJogo()
    {

        StartCoroutine("fase1");
        faseAtual = 1;
        Time.timeScale = 1;
    }

    public void SairDoJogo()
    {
        Application.Quit();
    }

    IEnumerator fase1()
    {
        yield return new WaitForSeconds(0.25f);
        UnityEngine.SceneManagement.SceneManager.LoadScene("Fase 1");
    }

    IEnumerator fase2()
    {
        yield return new WaitForSeconds(0.25f);
        UnityEngine.SceneManagement.SceneManager.LoadScene("Fase 2");
    }

}
