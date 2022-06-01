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
    public static int PagNumero;

    //PauseBotoes
    public GameObject[] MenuBotoes;

    //intruçoes
    public GameObject[] Instrucoes;
    bool InstrucoesExibir;
    

    void Start()
    {
        //Numero de pags
        NdePags[0].SetActive(true);

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
        if (PagNumero == 4)
        {
            NdePags[3].SetActive(false);
            NdePags[4].SetActive(true);
        }
        if (PagNumero == 5)
        {
            NdePags[4].SetActive(false);
            NdePags[5].SetActive(true);
        }
        if (PagNumero == 6)
        {
            NdePags[5].SetActive(false);
            NdePags[6].SetActive(true);
            StartCoroutine("FimDeJogo");
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
    
    public void IntruBotoes()
    {
            Instrucoes[0].SetActive(true);
            Instrucoes[1].SetActive(true);
            Instrucoes[2].SetActive(true);
            Instrucoes[3].SetActive(true);
            Instrucoes[4].SetActive(true);

            MenuBotoes[0].SetActive(false);
            MenuBotoes[1].SetActive(false);
            MenuBotoes[2].SetActive(false);
            MenuBotoes[3].SetActive(false);
    }

    public void Voltar()
    {
        Instrucoes[0].SetActive(false);
        Instrucoes[1].SetActive(false);
        Instrucoes[2].SetActive(false);
        Instrucoes[3].SetActive(false);
        Instrucoes[4].SetActive(false);

        MenuBotoes[0].SetActive(true);
        MenuBotoes[1].SetActive(true);
        MenuBotoes[2].SetActive(true);
        MenuBotoes[3].SetActive(true);
    }
}
