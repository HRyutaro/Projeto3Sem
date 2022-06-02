using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleFinal : MonoBehaviour
{
    public GameObject HudPuzzle;
    public GameObject HudPuzzleLivro;
    public GameObject textoSmPags;
    public GameObject interacao;
    bool dentroDaArea;
    bool[] estagio = new bool[5];
    //frase feitico
    public GameObject[] fraseFeitico;
    //botoes
    public GameObject feitico;
    //MagicFinal
    public GameObject magic;

    //posicoes Palavras do combat
    public Vector3[] Posicoes = new Vector3[8];
    //palavras Agua
    public GameObject[] Agua = new GameObject[8];

    //palavras fogo
    public GameObject[] fogo = new GameObject[8];

    //palavras Vento
    public GameObject[] Vento = new GameObject[8];

    //palavras raio
    public GameObject[] Raio = new GameObject[8];

    //palavra In Unum
    public GameObject[] inUnum = new GameObject[8];

    void Start()
    {
        HudPuzzle.SetActive(true);
    }


    void Update()
    {
        if(dentroDaArea == true)
        {
            if (Config.PagNumero < 6)
            {
                textoSmPags.SetActive(true);
            }
            else if (Config.PagNumero == 6)
            {
                interacao.SetActive(true);
                if(Input.GetKeyDown(KeyCode.E))
                {
                    Player2.Stop = true;
                    CameraController.lockCursor = false;
                    HudPuzzleLivro.SetActive(true);
                    feitico.SetActive(true);
                    interacao.SetActive(false);
                }
            }

        }
        else if (dentroDaArea == false)
        {
            HudPuzzleLivro.SetActive(false);
            textoSmPags.SetActive(false);
            feitico.SetActive(false);
            interacao.SetActive(false);
        }
    }

    void random()
    {
        int r = Random.Range(0, 7);


        switch (r)
        {
            case 0:
                Agua[0].SetActive(true);
                Agua[1].SetActive(true);
                Agua[2].SetActive(true);
                Agua[3].SetActive(true);
                Agua[4].SetActive(true);
                Agua[5].SetActive(true);
                Agua[6].SetActive(true);
                Agua[7].SetActive(true);
                Agua[0].transform.position = Posicoes[0];
                Agua[1].transform.position = Posicoes[1];
                Agua[2].transform.position = Posicoes[2];
                Agua[3].transform.position = Posicoes[3];
                Agua[4].transform.position = Posicoes[4];
                Agua[5].transform.position = Posicoes[5];
                Agua[6].transform.position = Posicoes[6];
                Agua[7].transform.position = Posicoes[7];
                break;
            case 1:
                Agua[0].SetActive(true);
                Agua[1].SetActive(true);
                Agua[2].SetActive(true);
                Agua[3].SetActive(true);
                Agua[4].SetActive(true);
                Agua[5].SetActive(true);
                Agua[6].SetActive(true);
                Agua[7].SetActive(true);
                Agua[0].transform.position = Posicoes[1];
                Agua[1].transform.position = Posicoes[7];
                Agua[2].transform.position = Posicoes[5];
                Agua[3].transform.position = Posicoes[2];
                Agua[4].transform.position = Posicoes[0];
                Agua[5].transform.position = Posicoes[4];
                Agua[6].transform.position = Posicoes[3];
                Agua[7].transform.position = Posicoes[6];
                break;
            case 2:
                Agua[0].SetActive(true);
                Agua[1].SetActive(true);
                Agua[2].SetActive(true);
                Agua[3].SetActive(true);
                Agua[4].SetActive(true);
                Agua[5].SetActive(true);
                Agua[6].SetActive(true);
                Agua[7].SetActive(true);
                Agua[0].transform.position = Posicoes[2];
                Agua[1].transform.position = Posicoes[4];
                Agua[2].transform.position = Posicoes[7];
                Agua[3].transform.position = Posicoes[5];
                Agua[4].transform.position = Posicoes[1];
                Agua[5].transform.position = Posicoes[3];
                Agua[6].transform.position = Posicoes[6];
                Agua[7].transform.position = Posicoes[0];
                break;
            case 3:
                Agua[0].SetActive(true);
                Agua[1].SetActive(true);
                Agua[2].SetActive(true);
                Agua[3].SetActive(true);
                Agua[4].SetActive(true);
                Agua[5].SetActive(true);
                Agua[6].SetActive(true);
                Agua[7].SetActive(true);
                Agua[0].transform.position = Posicoes[3];
                Agua[1].transform.position = Posicoes[1];
                Agua[2].transform.position = Posicoes[4];
                Agua[3].transform.position = Posicoes[0];
                Agua[4].transform.position = Posicoes[6];
                Agua[5].transform.position = Posicoes[2];
                Agua[6].transform.position = Posicoes[5];
                Agua[7].transform.position = Posicoes[7];
                break;
            case 4:
                Agua[0].SetActive(true);
                Agua[1].SetActive(true);
                Agua[2].SetActive(true);
                Agua[3].SetActive(true);
                Agua[4].SetActive(true);
                Agua[5].SetActive(true);
                Agua[6].SetActive(true);
                Agua[7].SetActive(true);
                Agua[0].transform.position = Posicoes[4];
                Agua[1].transform.position = Posicoes[0];
                Agua[2].transform.position = Posicoes[6];
                Agua[3].transform.position = Posicoes[7];
                Agua[4].transform.position = Posicoes[3];
                Agua[5].transform.position = Posicoes[5];
                Agua[6].transform.position = Posicoes[1];
                Agua[7].transform.position = Posicoes[2];
                break;
            case 5:
                Agua[0].SetActive(true);
                Agua[1].SetActive(true);
                Agua[2].SetActive(true);
                Agua[3].SetActive(true);
                Agua[4].SetActive(true);
                Agua[5].SetActive(true);
                Agua[6].SetActive(true);
                Agua[7].SetActive(true);
                Agua[0].transform.position = Posicoes[5];
                Agua[1].transform.position = Posicoes[1];
                Agua[2].transform.position = Posicoes[7];
                Agua[3].transform.position = Posicoes[4];
                Agua[4].transform.position = Posicoes[6];
                Agua[5].transform.position = Posicoes[2];
                Agua[6].transform.position = Posicoes[0];
                Agua[7].transform.position = Posicoes[3];
                break;
            case 6:
                Agua[0].SetActive(true);
                Agua[1].SetActive(true);
                Agua[2].SetActive(true);
                Agua[3].SetActive(true);
                Agua[4].SetActive(true);
                Agua[5].SetActive(true);
                Agua[6].SetActive(true);
                Agua[7].SetActive(true);
                Agua[0].transform.position = Posicoes[6];
                Agua[1].transform.position = Posicoes[5];
                Agua[2].transform.position = Posicoes[3];
                Agua[3].transform.position = Posicoes[7];
                Agua[4].transform.position = Posicoes[4];
                Agua[5].transform.position = Posicoes[1];
                Agua[6].transform.position = Posicoes[0];
                Agua[7].transform.position = Posicoes[2];
                break;
            case 7:
                Agua[0].SetActive(true);
                Agua[1].SetActive(true);
                Agua[2].SetActive(true);
                Agua[3].SetActive(true);
                Agua[4].SetActive(true);
                Agua[5].SetActive(true);
                Agua[6].SetActive(true);
                Agua[7].SetActive(true);
                Agua[0].transform.position = Posicoes[7];
                Agua[1].transform.position = Posicoes[3];
                Agua[2].transform.position = Posicoes[0];
                Agua[3].transform.position = Posicoes[6];
                Agua[4].transform.position = Posicoes[1];
                Agua[5].transform.position = Posicoes[4];
                Agua[6].transform.position = Posicoes[2];
                Agua[7].transform.position = Posicoes[5];
                break;


        }

    }
    void randomF()
    {
        int r = Random.Range(0, 7);


        switch (r)
        {
            case 0:
                fogo[0].SetActive(true);
                fogo[1].SetActive(true);
                fogo[2].SetActive(true);
                fogo[3].SetActive(true);
                fogo[4].SetActive(true);
                fogo[5].SetActive(true);
                fogo[6].SetActive(true);
                fogo[7].SetActive(true);
                fogo[0].transform.position = Posicoes[0];
                fogo[1].transform.position = Posicoes[1];
                fogo[2].transform.position = Posicoes[2];
                fogo[3].transform.position = Posicoes[3];
                fogo[4].transform.position = Posicoes[4];
                fogo[5].transform.position = Posicoes[5];
                fogo[6].transform.position = Posicoes[6];
                fogo[7].transform.position = Posicoes[7];
                break;
            case 1:
                fogo[0].SetActive(true);
                fogo[1].SetActive(true);
                fogo[2].SetActive(true);
                fogo[3].SetActive(true);
                fogo[4].SetActive(true);
                fogo[5].SetActive(true);
                fogo[6].SetActive(true);
                fogo[7].SetActive(true);
                fogo[0].transform.position = Posicoes[1];
                fogo[1].transform.position = Posicoes[7];
                fogo[2].transform.position = Posicoes[5];
                fogo[3].transform.position = Posicoes[2];
                fogo[4].transform.position = Posicoes[0];
                fogo[5].transform.position = Posicoes[4];
                fogo[6].transform.position = Posicoes[3];
                fogo[7].transform.position = Posicoes[6];
                break;
            case 2:
                fogo[0].SetActive(true);
                fogo[1].SetActive(true);
                fogo[2].SetActive(true);
                fogo[3].SetActive(true);
                fogo[4].SetActive(true);
                fogo[5].SetActive(true);
                fogo[6].SetActive(true);
                fogo[7].SetActive(true);
                fogo[0].transform.position = Posicoes[2];
                fogo[1].transform.position = Posicoes[4];
                fogo[2].transform.position = Posicoes[7];
                fogo[3].transform.position = Posicoes[5];
                fogo[4].transform.position = Posicoes[1];
                fogo[5].transform.position = Posicoes[3];
                fogo[6].transform.position = Posicoes[6];
                fogo[7].transform.position = Posicoes[0];
                break;
            case 3:
                fogo[0].SetActive(true);
                fogo[1].SetActive(true);
                fogo[2].SetActive(true);
                fogo[3].SetActive(true);
                fogo[4].SetActive(true);
                fogo[5].SetActive(true);
                fogo[6].SetActive(true);
                fogo[7].SetActive(true);
                fogo[0].transform.position = Posicoes[3];
                fogo[1].transform.position = Posicoes[1];
                fogo[2].transform.position = Posicoes[4];
                fogo[3].transform.position = Posicoes[0];
                fogo[4].transform.position = Posicoes[6];
                fogo[5].transform.position = Posicoes[2];
                fogo[6].transform.position = Posicoes[5];
                fogo[7].transform.position = Posicoes[7];
                break;
            case 4:
                fogo[0].SetActive(true);
                fogo[1].SetActive(true);
                fogo[2].SetActive(true);
                fogo[3].SetActive(true);
                fogo[4].SetActive(true);
                fogo[5].SetActive(true);
                fogo[6].SetActive(true);
                fogo[7].SetActive(true);
                fogo[0].transform.position = Posicoes[4];
                fogo[1].transform.position = Posicoes[0];
                fogo[2].transform.position = Posicoes[6];
                fogo[3].transform.position = Posicoes[7];
                fogo[4].transform.position = Posicoes[3];
                fogo[5].transform.position = Posicoes[5];
                fogo[6].transform.position = Posicoes[1];
                fogo[7].transform.position = Posicoes[2];
                break;
            case 5:
                fogo[0].SetActive(true);
                fogo[1].SetActive(true);
                fogo[2].SetActive(true);
                fogo[3].SetActive(true);
                fogo[4].SetActive(true);
                fogo[5].SetActive(true);
                fogo[6].SetActive(true);
                fogo[7].SetActive(true);
                fogo[0].transform.position = Posicoes[5];
                fogo[1].transform.position = Posicoes[1];
                fogo[2].transform.position = Posicoes[7];
                fogo[3].transform.position = Posicoes[4];
                fogo[4].transform.position = Posicoes[6];
                fogo[5].transform.position = Posicoes[2];
                fogo[6].transform.position = Posicoes[0];
                fogo[7].transform.position = Posicoes[3];
                break;
            case 6:
                fogo[0].SetActive(true);
                fogo[1].SetActive(true);
                fogo[2].SetActive(true);
                fogo[3].SetActive(true);
                fogo[4].SetActive(true);
                fogo[5].SetActive(true);
                fogo[6].SetActive(true);
                fogo[7].SetActive(true);
                fogo[0].transform.position = Posicoes[6];
                fogo[1].transform.position = Posicoes[5];
                fogo[2].transform.position = Posicoes[3];
                fogo[3].transform.position = Posicoes[7];
                fogo[4].transform.position = Posicoes[4];
                fogo[5].transform.position = Posicoes[1];
                fogo[6].transform.position = Posicoes[0];
                fogo[7].transform.position = Posicoes[2];
                break;
            case 7:
                fogo[0].SetActive(true);
                fogo[1].SetActive(true);
                fogo[2].SetActive(true);
                fogo[3].SetActive(true);
                fogo[4].SetActive(true);
                fogo[5].SetActive(true);
                fogo[6].SetActive(true);
                fogo[7].SetActive(true);
                fogo[0].transform.position = Posicoes[7];
                fogo[1].transform.position = Posicoes[3];
                fogo[2].transform.position = Posicoes[0];
                fogo[3].transform.position = Posicoes[6];
                fogo[4].transform.position = Posicoes[1];
                fogo[5].transform.position = Posicoes[4];
                fogo[6].transform.position = Posicoes[2];
                fogo[7].transform.position = Posicoes[5];
                break;


        }

    }
    void randomV()
    {
        int r = Random.Range(0, 7);


        switch (r)
        {
            case 0:
                Vento[0].SetActive(true);
                Vento[1].SetActive(true);
                Vento[2].SetActive(true);
                Vento[3].SetActive(true);
                Vento[4].SetActive(true);
                Vento[5].SetActive(true);
                Vento[6].SetActive(true);
                Vento[7].SetActive(true);
                Vento[0].transform.position = Posicoes[0];
                Vento[1].transform.position = Posicoes[1];
                Vento[2].transform.position = Posicoes[2];
                Vento[3].transform.position = Posicoes[3];
                Vento[4].transform.position = Posicoes[4];
                Vento[5].transform.position = Posicoes[5];
                Vento[6].transform.position = Posicoes[6];
                Vento[7].transform.position = Posicoes[7];
                break;
            case 1:
                Vento[0].SetActive(true);
                Vento[1].SetActive(true);
                Vento[2].SetActive(true);
                Vento[3].SetActive(true);
                Vento[4].SetActive(true);
                Vento[5].SetActive(true);
                Vento[6].SetActive(true);
                Vento[7].SetActive(true);
                Vento[0].transform.position = Posicoes[1];
                Vento[1].transform.position = Posicoes[7];
                Vento[2].transform.position = Posicoes[5];
                Vento[3].transform.position = Posicoes[2];
                Vento[4].transform.position = Posicoes[0];
                Vento[5].transform.position = Posicoes[4];
                Vento[6].transform.position = Posicoes[3];
                Vento[7].transform.position = Posicoes[6];
                break;
            case 2:
                Vento[0].SetActive(true);
                Vento[1].SetActive(true);
                Vento[2].SetActive(true);
                Vento[3].SetActive(true);
                Vento[4].SetActive(true);
                Vento[5].SetActive(true);
                Vento[6].SetActive(true);
                Vento[7].SetActive(true);
                Vento[0].transform.position = Posicoes[2];
                Vento[1].transform.position = Posicoes[4];
                Vento[2].transform.position = Posicoes[7];
                Vento[3].transform.position = Posicoes[5];
                Vento[4].transform.position = Posicoes[1];
                Vento[5].transform.position = Posicoes[3];
                Vento[6].transform.position = Posicoes[6];
                Vento[7].transform.position = Posicoes[0];
                break;
            case 3:
                Vento[0].SetActive(true);
                Vento[1].SetActive(true);
                Vento[2].SetActive(true);
                Vento[3].SetActive(true);
                Vento[4].SetActive(true);
                Vento[5].SetActive(true);
                Vento[6].SetActive(true);
                Vento[7].SetActive(true);
                Vento[0].transform.position = Posicoes[3];
                Vento[1].transform.position = Posicoes[1];
                Vento[2].transform.position = Posicoes[4];
                Vento[3].transform.position = Posicoes[0];
                Vento[4].transform.position = Posicoes[6];
                Vento[5].transform.position = Posicoes[2];
                Vento[6].transform.position = Posicoes[5];
                Vento[7].transform.position = Posicoes[7];
                break;
            case 4:
                Vento[0].SetActive(true);
                Vento[1].SetActive(true);
                Vento[2].SetActive(true);
                Vento[3].SetActive(true);
                Vento[4].SetActive(true);
                Vento[5].SetActive(true);
                Vento[6].SetActive(true);
                Vento[7].SetActive(true);
                Vento[0].transform.position = Posicoes[4];
                Vento[1].transform.position = Posicoes[5];
                Vento[2].transform.position = Posicoes[6];
                Vento[3].transform.position = Posicoes[7];
                Vento[4].transform.position = Posicoes[3];
                Vento[5].transform.position = Posicoes[0];
                Vento[6].transform.position = Posicoes[1];
                Vento[7].transform.position = Posicoes[2];
                break;
            case 5:
                Vento[0].SetActive(true);
                Vento[1].SetActive(true);
                Vento[2].SetActive(true);
                Vento[3].SetActive(true);
                Vento[4].SetActive(true);
                Vento[5].SetActive(true);
                Vento[6].SetActive(true);
                Vento[7].SetActive(true);
                Vento[0].transform.position = Posicoes[5];
                Vento[1].transform.position = Posicoes[1];
                Vento[2].transform.position = Posicoes[7];
                Vento[3].transform.position = Posicoes[4];
                Vento[4].transform.position = Posicoes[6];
                Vento[5].transform.position = Posicoes[2];
                Vento[6].transform.position = Posicoes[0];
                Vento[7].transform.position = Posicoes[3];
                break;
            case 6:
                Vento[0].SetActive(true);
                Vento[1].SetActive(true);
                Vento[2].SetActive(true);
                Vento[3].SetActive(true);
                Vento[4].SetActive(true);
                Vento[5].SetActive(true);
                Vento[6].SetActive(true);
                Vento[7].SetActive(true);
                Vento[0].transform.position = Posicoes[6];
                Vento[1].transform.position = Posicoes[0];
                Vento[2].transform.position = Posicoes[3];
                Vento[3].transform.position = Posicoes[7];
                Vento[4].transform.position = Posicoes[4];
                Vento[5].transform.position = Posicoes[1];
                Vento[6].transform.position = Posicoes[5];
                Vento[7].transform.position = Posicoes[2];
                break;
            case 7:
                Vento[0].SetActive(true);
                Vento[1].SetActive(true);
                Vento[2].SetActive(true);
                Vento[3].SetActive(true);
                Vento[4].SetActive(true);
                Vento[5].SetActive(true);
                Vento[6].SetActive(true);
                Vento[7].SetActive(true);
                Vento[0].transform.position = Posicoes[7];
                Vento[1].transform.position = Posicoes[3];
                Vento[2].transform.position = Posicoes[0];
                Vento[3].transform.position = Posicoes[6];
                Vento[4].transform.position = Posicoes[1];
                Vento[5].transform.position = Posicoes[4];
                Vento[6].transform.position = Posicoes[2];
                Vento[7].transform.position = Posicoes[5];
                break;


        }

    }
    void randomR()
    {
        int r = Random.Range(0, 7);


        switch (r)
        {
            case 0:
                Raio[0].SetActive(true);
                Raio[1].SetActive(true);
                Raio[2].SetActive(true);
                Raio[3].SetActive(true);
                Raio[4].SetActive(true);
                Raio[5].SetActive(true);
                Raio[6].SetActive(true);
                Raio[7].SetActive(true);
                Raio[0].transform.position = Posicoes[0];
                Raio[1].transform.position = Posicoes[1];
                Raio[2].transform.position = Posicoes[2];
                Raio[3].transform.position = Posicoes[3];
                Raio[4].transform.position = Posicoes[4];
                Raio[5].transform.position = Posicoes[5];
                Raio[6].transform.position = Posicoes[6];
                Raio[7].transform.position = Posicoes[7];
                break;
            case 1:
                Raio[0].SetActive(true);
                Raio[1].SetActive(true);
                Raio[2].SetActive(true);
                Raio[3].SetActive(true);
                Raio[4].SetActive(true);
                Raio[5].SetActive(true);
                Raio[6].SetActive(true);
                Raio[7].SetActive(true);
                Raio[0].transform.position = Posicoes[1];
                Raio[1].transform.position = Posicoes[7];
                Raio[2].transform.position = Posicoes[5];
                Raio[3].transform.position = Posicoes[2];
                Raio[4].transform.position = Posicoes[0];
                Raio[5].transform.position = Posicoes[4];
                Raio[6].transform.position = Posicoes[3];
                Raio[7].transform.position = Posicoes[6];
                break;
            case 2:
                Raio[0].SetActive(true);
                Raio[1].SetActive(true);
                Raio[2].SetActive(true);
                Raio[3].SetActive(true);
                Raio[4].SetActive(true);
                Raio[5].SetActive(true);
                Raio[6].SetActive(true);
                Raio[7].SetActive(true);
                Raio[0].transform.position = Posicoes[2];
                Raio[1].transform.position = Posicoes[4];
                Raio[2].transform.position = Posicoes[7];
                Raio[3].transform.position = Posicoes[5];
                Raio[4].transform.position = Posicoes[1];
                Raio[5].transform.position = Posicoes[3];
                Raio[6].transform.position = Posicoes[6];
                Raio[7].transform.position = Posicoes[0];
                break;
            case 3:
                Raio[0].SetActive(true);
                Raio[1].SetActive(true);
                Raio[2].SetActive(true);
                Raio[3].SetActive(true);
                Raio[4].SetActive(true);
                Raio[5].SetActive(true);
                Raio[6].SetActive(true);
                Raio[7].SetActive(true);
                Raio[0].transform.position = Posicoes[3];
                Raio[1].transform.position = Posicoes[1];
                Raio[2].transform.position = Posicoes[4];
                Raio[3].transform.position = Posicoes[0];
                Raio[4].transform.position = Posicoes[6];
                Raio[5].transform.position = Posicoes[2];
                Raio[6].transform.position = Posicoes[5];
                Raio[7].transform.position = Posicoes[7];
                break;
            case 4:
                Raio[0].SetActive(true);
                Raio[1].SetActive(true);
                Raio[2].SetActive(true);
                Raio[3].SetActive(true);
                Raio[4].SetActive(true);
                Raio[5].SetActive(true);
                Raio[6].SetActive(true);
                Raio[7].SetActive(true);
                Raio[0].transform.position = Posicoes[4];
                Raio[1].transform.position = Posicoes[5];
                Raio[2].transform.position = Posicoes[6];
                Raio[3].transform.position = Posicoes[7];
                Raio[4].transform.position = Posicoes[3];
                Raio[5].transform.position = Posicoes[0];
                Raio[6].transform.position = Posicoes[1];
                Raio[7].transform.position = Posicoes[2];
                break;
            case 5:
                Raio[0].SetActive(true);
                Raio[1].SetActive(true);
                Raio[2].SetActive(true);
                Raio[3].SetActive(true);
                Raio[4].SetActive(true);
                Raio[5].SetActive(true);
                Raio[6].SetActive(true);
                Raio[7].SetActive(true);
                Raio[0].transform.position = Posicoes[5];
                Raio[1].transform.position = Posicoes[1];
                Raio[2].transform.position = Posicoes[7];
                Raio[3].transform.position = Posicoes[4];
                Raio[4].transform.position = Posicoes[6];
                Raio[5].transform.position = Posicoes[2];
                Raio[6].transform.position = Posicoes[0];
                Raio[7].transform.position = Posicoes[3];
                break;
            case 6:
                Raio[0].SetActive(true);
                Raio[1].SetActive(true);
                Raio[2].SetActive(true);
                Raio[3].SetActive(true);
                Raio[4].SetActive(true);
                Raio[5].SetActive(true);
                Raio[6].SetActive(true);
                Raio[7].SetActive(true);
                Raio[0].transform.position = Posicoes[6];
                Raio[1].transform.position = Posicoes[0];
                Raio[2].transform.position = Posicoes[3];
                Raio[3].transform.position = Posicoes[7];
                Raio[4].transform.position = Posicoes[4];
                Raio[5].transform.position = Posicoes[1];
                Raio[6].transform.position = Posicoes[5];
                Raio[7].transform.position = Posicoes[2];
                break;
            case 7:
                Raio[0].SetActive(true);
                Raio[1].SetActive(true);
                Raio[2].SetActive(true);
                Raio[3].SetActive(true);
                Raio[4].SetActive(true);
                Raio[5].SetActive(true);
                Raio[6].SetActive(true);
                Raio[7].SetActive(true);
                Raio[0].transform.position = Posicoes[7];
                Raio[1].transform.position = Posicoes[3];
                Raio[2].transform.position = Posicoes[0];
                Raio[3].transform.position = Posicoes[6];
                Raio[4].transform.position = Posicoes[1];
                Raio[5].transform.position = Posicoes[4];
                Raio[6].transform.position = Posicoes[2];
                Raio[7].transform.position = Posicoes[5];
                break;


        }

    }
    void randomInUnum()
    {
        int r = Random.Range(0, 7);


        switch (r)
        {
            case 0:
                inUnum[0].SetActive(true);
                inUnum[1].SetActive(true);
                inUnum[2].SetActive(true);
                inUnum[3].SetActive(true);
                inUnum[4].SetActive(true);
                inUnum[5].SetActive(true);
                inUnum[6].SetActive(true);
                inUnum[7].SetActive(true);
                inUnum[0].transform.position = Posicoes[0];
                inUnum[1].transform.position = Posicoes[1];
                inUnum[2].transform.position = Posicoes[2];
                inUnum[3].transform.position = Posicoes[3];
                inUnum[4].transform.position = Posicoes[4];
                inUnum[5].transform.position = Posicoes[5];
                inUnum[6].transform.position = Posicoes[6];
                inUnum[7].transform.position = Posicoes[7];
                break;
            case 1:
                inUnum[0].SetActive(true);
                inUnum[1].SetActive(true);
                inUnum[2].SetActive(true);
                inUnum[3].SetActive(true);
                inUnum[4].SetActive(true);
                inUnum[5].SetActive(true);
                inUnum[6].SetActive(true);
                inUnum[7].SetActive(true);
                inUnum[0].transform.position = Posicoes[1];
                inUnum[1].transform.position = Posicoes[7];
                inUnum[2].transform.position = Posicoes[5];
                inUnum[3].transform.position = Posicoes[2];
                inUnum[4].transform.position = Posicoes[0];
                inUnum[5].transform.position = Posicoes[4];
                inUnum[6].transform.position = Posicoes[3];
                inUnum[7].transform.position = Posicoes[6];
                break;
            case 2:
                inUnum[0].SetActive(true);
                inUnum[1].SetActive(true);
                inUnum[2].SetActive(true);
                inUnum[3].SetActive(true);
                inUnum[4].SetActive(true);
                inUnum[5].SetActive(true);
                inUnum[6].SetActive(true);
                inUnum[7].SetActive(true);
                inUnum[0].transform.position = Posicoes[2];
                inUnum[1].transform.position = Posicoes[4];
                inUnum[2].transform.position = Posicoes[7];
                inUnum[3].transform.position = Posicoes[5];
                inUnum[4].transform.position = Posicoes[1];
                inUnum[5].transform.position = Posicoes[3];
                inUnum[6].transform.position = Posicoes[6];
                inUnum[7].transform.position = Posicoes[0];
                break;
            case 3:
                inUnum[0].SetActive(true);
                inUnum[1].SetActive(true);
                inUnum[2].SetActive(true);
                inUnum[3].SetActive(true);
                inUnum[4].SetActive(true);
                inUnum[5].SetActive(true);
                inUnum[6].SetActive(true);
                inUnum[7].SetActive(true);
                inUnum[0].transform.position = Posicoes[3];
                inUnum[1].transform.position = Posicoes[1];
                inUnum[2].transform.position = Posicoes[4];
                inUnum[3].transform.position = Posicoes[0];
                inUnum[4].transform.position = Posicoes[6];
                inUnum[5].transform.position = Posicoes[2];
                inUnum[6].transform.position = Posicoes[5];
                inUnum[7].transform.position = Posicoes[7];
                break;
            case 4:
                inUnum[0].SetActive(true);
                inUnum[1].SetActive(true);
                inUnum[2].SetActive(true);
                inUnum[3].SetActive(true);
                inUnum[4].SetActive(true);
                inUnum[5].SetActive(true);
                inUnum[6].SetActive(true);
                inUnum[7].SetActive(true);
                inUnum[0].transform.position = Posicoes[4];
                inUnum[1].transform.position = Posicoes[5];
                inUnum[2].transform.position = Posicoes[6];
                inUnum[3].transform.position = Posicoes[7];
                inUnum[4].transform.position = Posicoes[3];
                inUnum[5].transform.position = Posicoes[0];
                inUnum[6].transform.position = Posicoes[1];
                inUnum[7].transform.position = Posicoes[2];
                break;
            case 5:
                inUnum[0].SetActive(true);
                inUnum[1].SetActive(true);
                inUnum[2].SetActive(true);
                inUnum[3].SetActive(true);
                inUnum[4].SetActive(true);
                inUnum[5].SetActive(true);
                inUnum[6].SetActive(true);
                inUnum[7].SetActive(true);
                inUnum[0].transform.position = Posicoes[5];
                inUnum[1].transform.position = Posicoes[1];
                inUnum[2].transform.position = Posicoes[7];
                inUnum[3].transform.position = Posicoes[4];
                inUnum[4].transform.position = Posicoes[6];
                inUnum[5].transform.position = Posicoes[2];
                inUnum[6].transform.position = Posicoes[0];
                inUnum[7].transform.position = Posicoes[3];
                break;
            case 6:
                inUnum[0].SetActive(true);
                inUnum[1].SetActive(true);
                inUnum[2].SetActive(true);
                inUnum[3].SetActive(true);
                inUnum[4].SetActive(true);
                inUnum[5].SetActive(true);
                inUnum[6].SetActive(true);
                inUnum[7].SetActive(true);
                inUnum[0].transform.position = Posicoes[6];
                inUnum[1].transform.position = Posicoes[0];
                inUnum[2].transform.position = Posicoes[3];
                inUnum[3].transform.position = Posicoes[7];
                inUnum[4].transform.position = Posicoes[4];
                inUnum[5].transform.position = Posicoes[1];
                inUnum[6].transform.position = Posicoes[5];
                inUnum[7].transform.position = Posicoes[2];
                break;
            case 7:
                inUnum[0].SetActive(true);
                inUnum[1].SetActive(true);
                inUnum[2].SetActive(true);
                inUnum[3].SetActive(true);
                inUnum[4].SetActive(true);
                inUnum[5].SetActive(true);
                inUnum[6].SetActive(true);
                inUnum[7].SetActive(true);
                inUnum[0].transform.position = Posicoes[7];
                inUnum[1].transform.position = Posicoes[3];
                inUnum[2].transform.position = Posicoes[0];
                inUnum[3].transform.position = Posicoes[6];
                inUnum[4].transform.position = Posicoes[1];
                inUnum[5].transform.position = Posicoes[4];
                inUnum[6].transform.position = Posicoes[2];
                inUnum[7].transform.position = Posicoes[5];
                break;


        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            dentroDaArea = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            dentroDaArea = false;
        }
    }


    public void Feitico()
    {
        feitico.SetActive(false);
        random();
    }
    public void AcertouA()
    {
        fraseFeitico[0].SetActive(true);

        Agua[0].SetActive(false);
        Agua[1].SetActive(false);
        Agua[2].SetActive(false);
        Agua[3].SetActive(false);
        Agua[4].SetActive(false);
        Agua[5].SetActive(false);
        Agua[6].SetActive(false);
        Agua[7].SetActive(false);

        randomF();
    }
    public void AcertouF()
    {
        fraseFeitico[1].SetActive(true);

        fogo[0].SetActive(false);
        fogo[1].SetActive(false);
        fogo[2].SetActive(false);
        fogo[3].SetActive(false);
        fogo[4].SetActive(false);
        fogo[5].SetActive(false);
        fogo[6].SetActive(false);
        fogo[7].SetActive(false);

        randomV();
    }
    public void AcertouV()
    {
        fraseFeitico[2].SetActive(true);

        Vento[0].SetActive(false);
        Vento[1].SetActive(false);
        Vento[2].SetActive(false);
        Vento[3].SetActive(false);
        Vento[4].SetActive(false);
        Vento[5].SetActive(false);
        Vento[6].SetActive(false);
        Vento[7].SetActive(false);

        randomR();
    }
    public void AcertouR()
    {
        fraseFeitico[3].SetActive(true);

        Raio[0].SetActive(false);
        Raio[1].SetActive(false);
        Raio[2].SetActive(false);
        Raio[3].SetActive(false);
        Raio[4].SetActive(false);
        Raio[5].SetActive(false);
        Raio[6].SetActive(false);
        Raio[7].SetActive(false);

        randomInUnum();
    }
    public void AcertouEnUnum()
    {
        fraseFeitico[4].SetActive(true);
        StartCoroutine("GanhouOjogo");
    }
    IEnumerator GanhouOjogo()
    {
        yield return new WaitForSeconds(1f);
        HudPuzzle.SetActive(false);
        magic.SetActive(true);
        yield return new WaitForSeconds(5f);
        UnityEngine.SceneManagement.SceneManager.LoadScene("FimDeJogo");

    }
    public void Errou()
    {
        Player2.Vida --;
        if(Player2.Vida > 0)
        {

            fraseFeitico[0].SetActive(false);
            fraseFeitico[1].SetActive(false);
            fraseFeitico[2].SetActive(false);
            fraseFeitico[3].SetActive(false);

            fogo[0].SetActive(false);
            fogo[1].SetActive(false);
            fogo[2].SetActive(false);
            fogo[3].SetActive(false);
            fogo[4].SetActive(false);
            fogo[5].SetActive(false);
            fogo[6].SetActive(false);
            fogo[7].SetActive(false);

            Vento[0].SetActive(false);
            Vento[1].SetActive(false);
            Vento[2].SetActive(false);
            Vento[3].SetActive(false);
            Vento[4].SetActive(false);
            Vento[5].SetActive(false);
            Vento[6].SetActive(false);
            Vento[7].SetActive(false);

            Raio[0].SetActive(false);
            Raio[1].SetActive(false);
            Raio[2].SetActive(false);
            Raio[3].SetActive(false);
            Raio[4].SetActive(false);
            Raio[5].SetActive(false);
            Raio[6].SetActive(false);
            Raio[7].SetActive(false);

            inUnum[0].SetActive(false);
            inUnum[1].SetActive(false);
            inUnum[2].SetActive(false);
            inUnum[3].SetActive(false);
            inUnum[4].SetActive(false);
            inUnum[5].SetActive(false);
            inUnum[6].SetActive(false);
            inUnum[7].SetActive(false);

            random();
        }
        if(Player2.Vida <= 0)
        {
            HudPuzzle.SetActive(false);
        }
    }
}
