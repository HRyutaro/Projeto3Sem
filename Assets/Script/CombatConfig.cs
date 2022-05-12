using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatConfig : MonoBehaviour
{
    public GameObject HudCombat;
    public static bool HudCombatOn;
    public static bool HudCombatOff;

    public Vector3[] Posicoes = new Vector3[8];
    public Transform filho;

    public GameObject BAqua;
    private int PosicaoN1;

    void Start()
    {
        HudCombat.SetActive(false);
        HudCombatOn = false;

        PosicaoN1 = Random.Range(0, 8);
    }

    void Update()
    {
        if (HudCombatOn == true)
        {
            StartCoroutine(ShowHudcombat());
            palavrasCombat();
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

    public void palavrasCombat()
    {
        GameObject temp = Instantiate(BAqua, Posicoes[PosicaoN1], Quaternion.identity);
        temp.transform.SetParent(filho);
    }

    public void Acertou()
    {
        Enemy2.VidaI -- ;
        print("Acertou. Vida " + Enemy2.VidaI);
    }
    public void Errou()
    {
        Player2.Vida -- ;
        print("Errou. Vida " + Player2.Vida);
    }
}
