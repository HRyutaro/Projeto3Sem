using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botao2 : MonoBehaviour
{
    public GameObject Text;

    public GameObject Player;
    public GameObject PlayerButton;
    public GameObject npodeInteragir;
    private bool podeApertar;
    private bool jaApertou;

    void Start()
    {
        podeApertar = false;
        jaApertou = false;
    }


    void Update()
    {
        if(jaApertou == false)
        {
            if(podeApertar == true)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    StartCoroutine(Buttonpush());
                    jaApertou = true;
                }
            }
        }
    }
    IEnumerator Buttonpush()
    {
        PlayerButton.SetActive(true);
        PortaController2.podeAbrir = true;
        Player.SetActive(false);
        yield return new WaitForSeconds(1.5f);
        PlayerButton.SetActive(false);
        Player.SetActive(true);

    }

    private void OnTriggerEnter(Collider other)
    {
        if(Config.PagNumero >= 4)
        {
            if(jaApertou == false)
            {
                if (other.gameObject.CompareTag("Player"))
                {
                    podeApertar = true;
                    Text.SetActive(true);
                }
            }
        }
        else if(Config.PagNumero < 4)
        {
            npodeInteragir.SetActive(true);
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if(jaApertou == false)
        {
            podeApertar = false;
        }
        Text.SetActive(false);
        npodeInteragir.SetActive(false);
    }
}
