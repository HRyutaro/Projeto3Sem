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

    public void ChamaCenaDoJogo()
    {

        StartCoroutine("trocadecena");
        Time.timeScale = 1;
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

    IEnumerator trocadecena()
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
