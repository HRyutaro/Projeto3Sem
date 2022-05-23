using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatConfig : MonoBehaviour
{
    public GameObject HudCombat;
    public static bool HudCombatOn;
    public static bool HudCombatOff;
    bool pagA;
    bool pagF;
    bool pagV;
    bool pagR;

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

    //palavra dano
    public GameObject danoI;
    public GameObject danoIV;
    public GameObject danoPlayer;
    public GameObject AreaAtaque;
    bool Vantagem;

    //simbulos hudcombat

    public GameObject gota;
    public GameObject fogoS;
    public GameObject VentoS;
    public GameObject raioS;

    public GameObject proxP;
    public GameObject anteP;
    public GameObject voltar1;
    public GameObject voltar2;

    //vida inimigo
    public GameObject[] VHp = new GameObject[4];


    void Start()
    {
        HudCombat.SetActive(false);
        HudCombatOn = false;
        pagA = false;
        pagF = false;
        pagV = false;
        danoI.SetActive(false);
        danoIV.SetActive(false);
        danoPlayer.SetActive(false);
        AreaAtaque.SetActive(false);

        //vida Inimigo
        VHp[0].SetActive(false);
        VHp[1].SetActive(false);
        VHp[2].SetActive(false);
        VHp[3].SetActive(false);
    }

    void Update()
    {
        if (HudCombatOn == true)
        {
            StartCoroutine(ShowHudcombat());
            HudCombatOn = false;
        }

        if(HudCombatOff == true)
        {
            StartCoroutine(HideHudcombat());

        }

        //Combat
        if (Enemy2.VidaI == 3)
        {
            VHp[3].SetActive(false);
        }
        if (Enemy2.VidaI == 2)
        {

            VHp[2].SetActive(false);
            VHp[3].SetActive(false);
        }
        if (Enemy2.VidaI == 1)
        {
            VHp[1].SetActive(false);
            VHp[2].SetActive(false);
            VHp[3].SetActive(false);
        }
        if (Enemy2.VidaI <= 0)
        {
            HudCombatOff = true;
            Player2.OffCombat = true;
            VHp[0].SetActive(false);
            VHp[1].SetActive(false);
            VHp[2].SetActive(false);
            VHp[3].SetActive(false);
        }

    }

    public IEnumerator HideHudcombat()
    {
        CameraController.lockCursor = true;
        yield return new WaitForSeconds(0.25f);
        HudCombat.SetActive(false);
        Player2.Stop = false;
        HudCombatOff = false;
    }
    public IEnumerator ShowHudcombat()
    {
        CameraController.lockCursor = false;
        yield return new WaitForSeconds(0.25f);
        HudCombat.SetActive(true);
        gota.SetActive(true);
        fogoS.SetActive(true);
        proxP.SetActive(true);

        //VidaInimigo
        VHp[0].SetActive(true);
        VHp[1].SetActive(true);
        VHp[2].SetActive(true);
        VHp[3].SetActive(true);

    }

    void random()
    {
        int r = Random.Range(0, 7);
       

        switch(r)
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

    //botoes hudcombat

    public void ProxPag()
    {
        gota.SetActive(false);
        fogoS.SetActive(false);
        proxP.SetActive(false);

        VentoS.SetActive(true);
        raioS.SetActive(true);
        anteP.SetActive(true);
    }
    public void AntePag()
    {
        gota.SetActive(true);
        fogoS.SetActive(true);
        proxP.SetActive(true);

        VentoS.SetActive(false);
        raioS.SetActive(false);
        anteP.SetActive(false);
    }

    public void Voltar1()
    {
        //palavra agua
        voltar1.SetActive(false);
        Agua[0].SetActive(false);
        Agua[1].SetActive(false);
        Agua[2].SetActive(false);
        Agua[3].SetActive(false);
        Agua[4].SetActive(false);
        Agua[5].SetActive(false);
        Agua[6].SetActive(false);
        Agua[7].SetActive(false);

        //palavra fogo
        fogo[0].SetActive(false);
        fogo[1].SetActive(false);
        fogo[2].SetActive(false);
        fogo[3].SetActive(false);
        fogo[4].SetActive(false);
        fogo[5].SetActive(false);
        fogo[6].SetActive(false);
        fogo[7].SetActive(false);

        danoI.SetActive(false);
        danoIV.SetActive(false);
        danoPlayer.SetActive(false);

        gota.SetActive(true);
        fogoS.SetActive(true);
        proxP.SetActive(true);
        Vantagem = false;
        pagF = false;
        pagA = false;

    }
    public void Voltar2()
    {
        voltar2.SetActive(false);
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

        danoI.SetActive(false);
        danoIV.SetActive(false);
        danoPlayer.SetActive(false);

        VentoS.SetActive(true);
        raioS.SetActive(true);
        anteP.SetActive(true);
        Vantagem = false;
        pagV = false;
        pagR = false;
    }

    public void raio()
    {
        raioS.SetActive(false);
        VentoS.SetActive(false);
        anteP.SetActive(false);

        voltar2.SetActive(true);
        pagR = true;
        if (Enemy2.TipoDIAgua == true)
        {
            Vantagem = true;
        }
        else
        {
            Vantagem = false;
        }

        randomR();
    }
    public void vento()
    {
        raioS.SetActive(false);
        VentoS.SetActive(false);
        anteP.SetActive(false);

        voltar2.SetActive(true);
        randomV();
        pagV = true;

        if (Enemy2.TipoDIRaio == true)
        {
            Vantagem = true;
        }
        else
        {
            Vantagem = false;
        }
    }
    public void Fogo()
    {
        fogoS.SetActive(false);
        gota.SetActive(false);
        proxP.SetActive(false);

        voltar1.SetActive(true);
        randomF();
        pagF = true;
        if (Enemy2.TipoDIVento == true)
        {
            Vantagem = true;
        }
        else
        {
            Vantagem = false;
        }
    }
    public void Gota()
    {
        fogoS.SetActive(false);
        gota.SetActive(false);
        proxP.SetActive(false);

        voltar1.SetActive(true);
        random();
        pagA = true;
        if(Enemy2.TipoDIFogo == true)
        {
            Vantagem = true;
        }
        else
        {
            Vantagem = false;
        }

    }
    public void Acertou()
    {
        if(Vantagem == true)
        {
            Enemy2.VidaI -= 2;
            danoI.SetActive(false);
            danoIV.SetActive(true);
            danoPlayer.SetActive(false);
            print("Acertou.com vantagem Vida " + Enemy2.VidaI);
            if(Enemy2.VidaI <= 0)
            {
                StartCoroutine("AtivarArea");
            }
        }
        else if(Vantagem == false)
        {
            Enemy2.VidaI -= 1;
            danoI.SetActive(true);
            danoIV.SetActive(false);
            danoPlayer.SetActive(false);
            print("Acertou.sem vantagem Vida " + Enemy2.VidaI);
            if (Enemy2.VidaI <= 0)
            {
                StartCoroutine("AtivarArea");
            }
        }

        if(pagA == true)
        {
            random();
        }
        if(pagF == true)
        {
            randomF();
        }
        if(pagV == true)
        {
            randomV();
        }
        if(pagR == true)
        {
            randomR();
        }

    }
    public void Errou()
    {
        Player2.Vida -- ;
        danoI.SetActive(false);
        danoIV.SetActive(false);
        danoPlayer.SetActive(true);
        Enemy2.atacandoI = true;
        print("Errou. Vida " + Player2.Vida);
    }

    IEnumerator AtivarArea()
    {
        AreaAtaque.SetActive(true);
        yield return new WaitForSeconds(1f);
        AreaAtaque.SetActive(false);
    }
}
