using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botao : MonoBehaviour
{
    public GameObject Text;

    void Start()
    {
        
    }


    void Update()
    {
        
    }
    
    private void OnTriggerEnter(Collider other)
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
    private void OnTriggerExit(Collider other)
    {

        Text.SetActive(false);
    }

}
