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

    //intru�oes
    public GameObject[] Instrucoes;
    bool InstrucoesExibir;

    public static bool CombatOn;
    

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
                if(CombatOn == true)
                {
                    Pause.SetActive(true);
                    Time.timeScale = 0;
                }
                else
                {
                    Pause.SetActive(true);
                    CameraController.lockCursor = false;
                    Time.timeScale = 0;
                }
            }
            else if(Time.timeScale == 0)
            {
                if(CombatOn == true)
                {
                    Pause.SetActive(false);
                    Time.timeScale = 1;
                }
                else
                {
                    Pause.SetActive(false);
                    CameraController.lockCursor = true;
                    Time.timeScale = 1;
                }
            }

        }


        if(PagNumero == 1)
        {
            NdePags[0].SetActive(false);
            NdePags[1].SetActive(true);
            NdePags[2].SetActive(false);
            NdePags[3].SetActive(false);
            NdePags[4].SetActive(false);
            NdePags[5].SetActive(false);
            NdePags[6].SetActive(false);
        }
        if (PagNumero == 2)
        {
            NdePags[0].SetActive(false);
            NdePags[1].SetActive(false);
            NdePags[2].SetActive(true);
            NdePags[3].SetActive(false);
            NdePags[4].SetActive(false);
            NdePags[5].SetActive(false);
            NdePags[6].SetActive(false);
        }
        if (PagNumero == 3)
        {
            NdePags[0].SetActive(false);
            NdePags[1].SetActive(false);
            NdePags[2].SetActive(false);
            NdePags[3].SetActive(true);
            NdePags[4].SetActive(false);
            NdePags[5].SetActive(false);
            NdePags[6].SetActive(false);
        }
        if (PagNumero == 4)
        {
            NdePags[0].SetActive(false);
            NdePags[1].SetActive(false);
            NdePags[2].SetActive(false);
            NdePags[3].SetActive(false);
            NdePags[4].SetActive(true);
            NdePags[5].SetActive(false);
            NdePags[6].SetActive(false);
        }
        if (PagNumero == 5)
        {
            NdePags[0].SetActive(false);
            NdePags[1].SetActive(false);
            NdePags[2].SetActive(false);
            NdePags[3].SetActive(false);
            NdePags[4].SetActive(false);
            NdePags[5].SetActive(true);
            NdePags[6].SetActive(false);
        }
        if (PagNumero == 6)
        {
            NdePags[0].SetActive(false);
            NdePags[1].SetActive(false);
            NdePags[2].SetActive(false);
            NdePags[3].SetActive(false);
            NdePags[4].SetActive(false);
            NdePags[5].SetActive(false);
            NdePags[6].SetActive(true);
        }

    }

    IEnumerator FimDeJogo()
    {
        yield return new WaitForSeconds(1f);
        UnityEngine.SceneManagement.SceneManager.LoadScene("FimDeJogo");
    }

    //Bot�es
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
        Instrucoes[5].SetActive(true);
        Instrucoes[6].SetActive(true);

        MenuBotoes[0].SetActive(false);
        MenuBotoes[1].SetActive(false);
        MenuBotoes[2].SetActive(false);
        MenuBotoes[3].SetActive(false);
        MenuBotoes[4].SetActive(false);
    }

    public void Voltar()
    {
        Instrucoes[0].SetActive(false);
        Instrucoes[1].SetActive(false);
        Instrucoes[2].SetActive(false);
        Instrucoes[3].SetActive(false);
        Instrucoes[4].SetActive(false);
        Instrucoes[5].SetActive(false);
        Instrucoes[6].SetActive(false);

        MenuBotoes[0].SetActive(true);
        MenuBotoes[1].SetActive(true);
        MenuBotoes[2].SetActive(true);
        MenuBotoes[3].SetActive(true);
        MenuBotoes[4].SetActive(true);
    }
}
