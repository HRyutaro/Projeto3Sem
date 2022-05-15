using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatConfig : MonoBehaviour
{
    public GameObject HudCombat;
    public static bool HudCombatOn;
    public static bool HudCombatOff;

    //posicoes Palavras do combat
    public Vector3[] Posicoes = new Vector3[8];
    public GameObject PosicaoN;
    public GameObject PosicaoN1;
    public GameObject PosicaoN2;
    public GameObject PosicaoN3;
    public GameObject PosicaoN4;
    public GameObject PosicaoN5;
    public GameObject PosicaoN6;
    public GameObject PosicaoN7;

    //simbulos hudcombat

    public GameObject gota;
    public GameObject fogo;
    public GameObject vento;
    public GameObject raio;

    public GameObject proxP;
    public GameObject anteP;
    public GameObject voltar1;
    public GameObject voltar2;

    bool Vantagem;

    void Start()
    {
        HudCombat.SetActive(false);
        HudCombatOn = false;

    }

    void Update()
    {
        if (HudCombatOn == true)
        {
            gota.SetActive(true);
            fogo.SetActive(true);
            proxP.SetActive(true);
            StartCoroutine(ShowHudcombat());
            HudCombatOn = false;
        }

        if(HudCombatOff == true)
        {
            StartCoroutine(HideHudcombat());
        }

        
    }

    public IEnumerator HideHudcombat()
    {
        CameraController.lockCursor = true;
        yield return new WaitForSeconds(0.25f);
        HudCombat.SetActive(false);
        Player2.Stop = false;
    }
    public IEnumerator ShowHudcombat()
    {
        CameraController.lockCursor = false;
        yield return new WaitForSeconds(0.25f);
        HudCombat.SetActive(true);
    }

    void random()
    {
        int r = Random.Range(0, 7);
        print("random N " + r);

        switch(r)
        {
            case 0:
                PosicaoN.SetActive(true);
                PosicaoN1.SetActive(true);
                PosicaoN2.SetActive(true);
                PosicaoN3.SetActive(true);
                PosicaoN4.SetActive(true);
                PosicaoN5.SetActive(true);
                PosicaoN6.SetActive(true);
                PosicaoN7.SetActive(true);
                PosicaoN.transform.position = Posicoes[0];
                PosicaoN1.transform.position = Posicoes[1];
                PosicaoN2.transform.position = Posicoes[2];
                PosicaoN3.transform.position = Posicoes[3];
                PosicaoN4.transform.position = Posicoes[4];
                PosicaoN5.transform.position = Posicoes[5];
                PosicaoN6.transform.position = Posicoes[6];
                PosicaoN7.transform.position = Posicoes[7];
                break;
            case 1:
                PosicaoN.SetActive(true);
                PosicaoN1.SetActive(true);
                PosicaoN2.SetActive(true);
                PosicaoN3.SetActive(true);
                PosicaoN4.SetActive(true);
                PosicaoN5.SetActive(true);
                PosicaoN6.SetActive(true);
                PosicaoN7.SetActive(true);
                PosicaoN.transform.position = Posicoes[1];
                PosicaoN1.transform.position = Posicoes[7];
                PosicaoN2.transform.position = Posicoes[5];
                PosicaoN3.transform.position = Posicoes[2];
                PosicaoN4.transform.position = Posicoes[0];
                PosicaoN5.transform.position = Posicoes[4];
                PosicaoN6.transform.position = Posicoes[3];
                PosicaoN7.transform.position = Posicoes[6];
                break;
            case 2:
                PosicaoN.SetActive(true);
                PosicaoN1.SetActive(true);
                PosicaoN2.SetActive(true);
                PosicaoN3.SetActive(true);
                PosicaoN4.SetActive(true);
                PosicaoN5.SetActive(true);
                PosicaoN6.SetActive(true);
                PosicaoN7.SetActive(true);
                PosicaoN.transform.position = Posicoes[2];
                PosicaoN1.transform.position = Posicoes[4];
                PosicaoN2.transform.position = Posicoes[7];
                PosicaoN3.transform.position = Posicoes[5];
                PosicaoN4.transform.position = Posicoes[1];
                PosicaoN5.transform.position = Posicoes[3];
                PosicaoN6.transform.position = Posicoes[6];
                PosicaoN7.transform.position = Posicoes[0];
                break;
            case 3:
                PosicaoN.SetActive(true);
                PosicaoN1.SetActive(true);
                PosicaoN2.SetActive(true);
                PosicaoN3.SetActive(true);
                PosicaoN4.SetActive(true);
                PosicaoN5.SetActive(true);
                PosicaoN6.SetActive(true);
                PosicaoN7.SetActive(true);
                PosicaoN.transform.position = Posicoes[3];
                PosicaoN1.transform.position = Posicoes[1];
                PosicaoN2.transform.position = Posicoes[4];
                PosicaoN3.transform.position = Posicoes[0];
                PosicaoN4.transform.position = Posicoes[6];
                PosicaoN5.transform.position = Posicoes[2];
                PosicaoN6.transform.position = Posicoes[5];
                PosicaoN7.transform.position = Posicoes[7];
                break;
            case 4:
                PosicaoN.SetActive(true);
                PosicaoN1.SetActive(true);
                PosicaoN2.SetActive(true);
                PosicaoN3.SetActive(true);
                PosicaoN4.SetActive(true);
                PosicaoN5.SetActive(true);
                PosicaoN6.SetActive(true);
                PosicaoN7.SetActive(true);
                PosicaoN.transform.position = Posicoes[4];
                PosicaoN1.transform.position = Posicoes[0];
                PosicaoN2.transform.position = Posicoes[2];
                PosicaoN3.transform.position = Posicoes[7];
                PosicaoN4.transform.position = Posicoes[3];
                PosicaoN5.transform.position = Posicoes[5];
                PosicaoN6.transform.position = Posicoes[1];
                PosicaoN7.transform.position = Posicoes[2];
                break;
            case 5:
                PosicaoN.SetActive(true);
                PosicaoN1.SetActive(true);
                PosicaoN2.SetActive(true);
                PosicaoN3.SetActive(true);
                PosicaoN4.SetActive(true);
                PosicaoN5.SetActive(true);
                PosicaoN6.SetActive(true);
                PosicaoN7.SetActive(true);
                PosicaoN.transform.position = Posicoes[5];
                PosicaoN1.transform.position = Posicoes[1];
                PosicaoN2.transform.position = Posicoes[7];
                PosicaoN3.transform.position = Posicoes[4];
                PosicaoN4.transform.position = Posicoes[6];
                PosicaoN5.transform.position = Posicoes[2];
                PosicaoN6.transform.position = Posicoes[0];
                PosicaoN7.transform.position = Posicoes[3];
                break;
            case 6:
                PosicaoN.SetActive(true);
                PosicaoN1.SetActive(true);
                PosicaoN2.SetActive(true);
                PosicaoN3.SetActive(true);
                PosicaoN4.SetActive(true);
                PosicaoN5.SetActive(true);
                PosicaoN6.SetActive(true);
                PosicaoN7.SetActive(true);
                PosicaoN.transform.position = Posicoes[6];
                PosicaoN1.transform.position = Posicoes[0];
                PosicaoN2.transform.position = Posicoes[3];
                PosicaoN3.transform.position = Posicoes[7];
                PosicaoN4.transform.position = Posicoes[4];
                PosicaoN5.transform.position = Posicoes[1];
                PosicaoN6.transform.position = Posicoes[5];
                PosicaoN7.transform.position = Posicoes[2];
                break;
            case 7:
                PosicaoN.SetActive(true);
                PosicaoN1.SetActive(true);
                PosicaoN2.SetActive(true);
                PosicaoN3.SetActive(true);
                PosicaoN4.SetActive(true);
                PosicaoN5.SetActive(true);
                PosicaoN6.SetActive(true);
                PosicaoN7.SetActive(true);
                PosicaoN.transform.position = Posicoes[7];
                PosicaoN1.transform.position = Posicoes[3];
                PosicaoN2.transform.position = Posicoes[0];
                PosicaoN3.transform.position = Posicoes[6];
                PosicaoN4.transform.position = Posicoes[1];
                PosicaoN5.transform.position = Posicoes[4];
                PosicaoN6.transform.position = Posicoes[2];
                PosicaoN7.transform.position = Posicoes[5];
                break;


        }

    }

    //botoes hudcombat

    public void ProxPag()
    {
        gota.SetActive(false);
        fogo.SetActive(false);
        proxP.SetActive(false);

        vento.SetActive(true);
        raio.SetActive(true);
        anteP.SetActive(true);
    }
    public void AntePag()
    {
        gota.SetActive(true);
        fogo.SetActive(true);
        proxP.SetActive(true);

        vento.SetActive(false);
        raio.SetActive(false);
        anteP.SetActive(false);
    }

    public void Voltar1()
    {
        voltar1.SetActive(false);
        PosicaoN.SetActive(false);
        PosicaoN1.SetActive(false);
        PosicaoN2.SetActive(false);
        PosicaoN3.SetActive(false);
        PosicaoN4.SetActive(false);
        PosicaoN5.SetActive(false);
        PosicaoN6.SetActive(false);
        PosicaoN7.SetActive(false);

        gota.SetActive(true);
        fogo.SetActive(true);
        proxP.SetActive(true);
        Vantagem = false;
    }
    public void Voltar2()
    {
        voltar2.SetActive(false);
        PosicaoN.SetActive(false);
        PosicaoN1.SetActive(false);
        PosicaoN2.SetActive(false);
        PosicaoN3.SetActive(false);
        PosicaoN4.SetActive(false);
        PosicaoN5.SetActive(false);
        PosicaoN6.SetActive(false);
        PosicaoN7.SetActive(false);

        vento.SetActive(true);
        raio.SetActive(true);
        anteP.SetActive(true);
        Vantagem = false;
    }

    public void Raio()
    {
        raio.SetActive(false);
        vento.SetActive(false);
        anteP.SetActive(false);

        voltar2.SetActive(true);
        if (Enemy2.TipoDIAgua == true)
        {
            Vantagem = true;
        }
        else
        {
            Vantagem = false;
        }

        random();
    }
    public void Vento()
    {
        raio.SetActive(false);
        vento.SetActive(false);
        anteP.SetActive(false);

        voltar2.SetActive(true);
        if (Enemy2.TipoDIRaio == true)
        {
            Vantagem = true;
        }
        else
        {
            Vantagem = false;
        }
        random();
    }
    public void Fogo()
    {
        fogo.SetActive(false);
        gota.SetActive(false);
        proxP.SetActive(false);

        voltar1.SetActive(true);
        if (Enemy2.TipoDIVento == true)
        {
            Vantagem = true;
        }
        else
        {
            Vantagem = false;
        }
        random();
    }
    public void Gota()
    {
        fogo.SetActive(false);
        gota.SetActive(false);
        proxP.SetActive(false);

        voltar1.SetActive(true);
        random();
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
                print("Acertou.com vantagem Vida " + Enemy2.VidaI);
            }
        else if(Vantagem == false)
            {
                Enemy2.VidaI --;
                print("Acertou.sem vantagem Vida " + Enemy2.VidaI);
            }
        random();

    }
    public void Errou()
    {
        Player2.Vida -- ;
        print("Errou. Vida " + Player2.Vida);
    }
}
