using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotaoMovimento : MonoBehaviour
{
    private int casaAtual = 0;
    public Vector3[] casas = new Vector3[2];
    public int casaFinal;
    public static bool podeApertar;
    public static bool apertou;

    public GameObject Player;
    public GameObject PlayerButton;

    void Start()
    {
        podeApertar = false;
        transform.position = casas[casaAtual];
        apertou = false;
    }


    void Update()
    {
       
        if (podeApertar == true)
        {
            if (apertou == false)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    StartCoroutine(Buttonpush());
                    apertou = true;
                }

            }
        }
    }

    IEnumerator MoviLerp(Vector3 targetPosition, float duration)
    {

        float time = 0;
        Vector3 startPosition = transform.position;
        while (time < duration)
        {
            transform.position = Vector3.Lerp(startPosition, targetPosition, time / duration);
            time += Time.deltaTime;
            yield return null;
        }
        transform.position = targetPosition;
    }

    IEnumerator Buttonpush()
    {
        PlayerButton.SetActive(true);
        StartCoroutine(MoviLerp(casas[casaAtual = 1], 2f));
        Player.SetActive(false);
        yield return new WaitForSeconds(3f);
        PlayerButton.SetActive(false);
        Player.SetActive(true);
        podeApertar = false;
        PortaController1.Apertou = true;
    }
}
