using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerCartas2 : MonoBehaviour
{
    public GameObject[] Pags;
    bool ExibirPag4;
    bool ExibirPag5;
    bool ExibirPag6;

    void Start()
    {

    }

    void Update()
    {
        if (ExibirPag4 == true)
        {
            Pags[0].SetActive(true);
        }
        else
        {
            Pags[0].SetActive(false);
        }
        if (ExibirPag5 == true)
        {
            Pags[1].SetActive(true);
        }
        else
        {
            Pags[1].SetActive(false);
        }
        if (ExibirPag6 == true)
        {
            Pags[2].SetActive(true);
        }
        else
        {
            Pags[2].SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            if (Config.PagNumero == 4)
            {
                ExibirPag4 = !ExibirPag4;
            }
            if (Config.PagNumero == 5)
            {
                ExibirPag5 = !ExibirPag5;
            }
            if (Config.PagNumero == 6)
            {
                ExibirPag6 = !ExibirPag6;
            }

        }

    }
}
