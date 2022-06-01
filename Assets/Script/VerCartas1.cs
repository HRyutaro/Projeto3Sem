using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerCartas1 : MonoBehaviour
{
    public GameObject[] Pags;
    bool ExibirPag0 ;
    bool ExibirPag1 ;
    bool ExibirPag2 ;

    void Start()
    {
        
    }

    void Update()
    {
        if(ExibirPag0 == true)
        {
            Pags[0].SetActive(true);
        }
        else
        {
            Pags[0].SetActive(false);
        }
        if (ExibirPag1 == true)
        {
            Pags[1].SetActive(true);
        }
        else
        {
            Pags[1].SetActive(false);
        }
        if (ExibirPag2 == true)
        {
            Pags[2].SetActive(true);
        }
        else
        {
            Pags[2].SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            if(Config.PagNumero == 1)
            {
                ExibirPag0 = !ExibirPag0;
            }
            if (Config.PagNumero == 2)
            {
                ExibirPag1 = !ExibirPag1;
            }
            if (Config.PagNumero == 3)
            {
                ExibirPag2 = !ExibirPag2;
            }
        }

    }
}
