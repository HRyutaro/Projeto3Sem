using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuInicial : MonoBehaviour
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

    public void SairDoJogo()
    {
        Application.Quit();
    }

    IEnumerator trocadecena()
    {
        yield return new WaitForSeconds(0.25f);
        UnityEngine.SceneManagement.SceneManager.LoadScene("Fase 1");
    }

}
