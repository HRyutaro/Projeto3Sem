using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botao : MonoBehaviour
{
    public GameObject Text;
    public GameObject NpodeInteragir;

    void Start()
    {
        
    }


    void Update()
    {
        
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if(Config.PagNumero < 2)
        {
            NpodeInteragir.SetActive(true);
        }
        else if(Config.PagNumero >= 2)
        {
            if (BotaoMovimento.apertou == false)
            {
                if(other.gameObject.CompareTag("Player"))
                {
                    BotaoMovimento.podeApertar = true;
                    Text.SetActive(true);
                }
            }

        }

    }
    private void OnTriggerExit(Collider other)
    {

        NpodeInteragir.SetActive(false);
        Text.SetActive(false);
    }

}
