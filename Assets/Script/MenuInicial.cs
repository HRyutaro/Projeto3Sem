using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuInicial : MonoBehaviour
{
    public static int faseAtual;
    public GameObject continuar;

    public GameObject MeiNivel1;
    public GameObject MeiNivel2;

    public AudioSource Porta;
    public GameObject[] BotaoInstrucao;

    bool ExibirInstrucao;

    void Start()
    {
        if (faseAtual > 1)
        {
            continuar.SetActive(true);
            MeiNivel1.SetActive(false);
            MeiNivel2.SetActive(true);
        }
        ExibirInstrucao = false;
    }

    void Update()
    {
        if(ExibirInstrucao == true)
        {
            BotaoInstrucao[0].SetActive(true);
            BotaoInstrucao[1].SetActive(true);
            BotaoInstrucao[2].SetActive(true);
            BotaoInstrucao[3].SetActive(true);
            BotaoInstrucao[4].SetActive(true);
            BotaoInstrucao[5].SetActive(true);
        }
        else
        {
            BotaoInstrucao[0].SetActive(false);
            BotaoInstrucao[1].SetActive(false);
            BotaoInstrucao[2].SetActive(false);
            BotaoInstrucao[3].SetActive(false);
            BotaoInstrucao[4].SetActive(false);
            BotaoInstrucao[5].SetActive(false);
        }
    }

    public void Continuar()
    {
        if (faseAtual == 2)
        {
            Config.PagNumero = 3;
            StartCoroutine("fase2");
        }
    }


    public void NovoJogo()
    {

        StartCoroutine("fase1");
        faseAtual = 1;
        Time.timeScale = 1;
        Config.PagNumero = 0;
    }

    public void SairDoJogo()
    {
        Application.Quit();
    }

    IEnumerator fase1()
    {
        yield return new WaitForSeconds(5f);
        UnityEngine.SceneManagement.SceneManager.LoadScene("Fase 1");
    }

    IEnumerator fase2()
    {
        yield return new WaitForSeconds(0.25f);
        UnityEngine.SceneManagement.SceneManager.LoadScene("Fase 2");
    }

    public void PlaySom()
    {
        Porta.Play();
    }

    public void botaoInstrucao()
    {
        ExibirInstrucao = !ExibirInstrucao;  
    }
}
