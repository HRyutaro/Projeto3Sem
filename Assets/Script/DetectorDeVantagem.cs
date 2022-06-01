using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorDeVantagem : MonoBehaviour
{
    public static bool TipoDIFogo;
    public static bool TipoDIAgua;
    public static bool TipoDIRaio;
    public static bool TipoDIVento;

    public GameObject NomeAgua;
    public GameObject NomeFogo;
    public GameObject NomeRaio;
    public GameObject NomeVento;
    void Start()
    {
        TipoDIAgua = false;
        TipoDIFogo = false;
        TipoDIVento = false;
        TipoDIRaio = false;

        NomeAgua.SetActive(false);
        NomeFogo.SetActive(false);
        NomeRaio.SetActive(false);
        NomeVento.SetActive(false);
    }

    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "InimigoAgua")
        {

            TipoDIAgua = true;
            TipoDIFogo = false;
            TipoDIRaio = false;
            TipoDIVento = false;

            NomeAgua.SetActive(true);
            NomeFogo.SetActive(false);
            NomeRaio.SetActive(false);
            NomeVento.SetActive(false);
        }
        else if(other.tag == "InimigoFogo")
        {
            TipoDIAgua = false;
            TipoDIFogo = true;
            TipoDIVento = false;
            TipoDIRaio = false;

            NomeAgua.SetActive(false);
            NomeFogo.SetActive(true);
            NomeRaio.SetActive(false);
            NomeVento.SetActive(false);
        }
        else if (other.tag == "InimigoVento")
        {
            TipoDIAgua = false;
            TipoDIFogo = false;
            TipoDIRaio = false;
            TipoDIVento = true;

            NomeAgua.SetActive(false);
            NomeFogo.SetActive(false);
            NomeRaio.SetActive(false);
            NomeVento.SetActive(true);
        }
        else if (other.tag == "InimigoRaio")
        {
            TipoDIAgua = false;
            TipoDIFogo = false;
            TipoDIRaio = true;
            TipoDIVento = false;

            NomeAgua.SetActive(false);
            NomeFogo.SetActive(false);
            NomeRaio.SetActive(true);
            NomeVento.SetActive(false);
        }
        else
        {
            TipoDIAgua = false;
            TipoDIFogo = false;
            TipoDIRaio = false;
            TipoDIVento = false;

            NomeAgua.SetActive(false);
            NomeFogo.SetActive(false);
            NomeRaio.SetActive(false);
            NomeVento.SetActive(false);
        }
       
    }

    void OnTriggerExit(Collider other)
    {
        TipoDIAgua = false;
        TipoDIFogo = false;
        TipoDIVento = false;
        TipoDIRaio = false;

        NomeAgua.SetActive(false);
        NomeFogo.SetActive(false);
        NomeRaio.SetActive(false);
        NomeVento.SetActive(false);
        
    }

}
