using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortaController1 : MonoBehaviour
{

    private int casaAtual = 0;
    public Vector3[] casas = new Vector3[2];
    public int casaFinal;
    public static bool Apertou = false;

    void Start()
    {
        Apertou = false;
        transform.position = casas[casaAtual];
    }


    void Update()
    {
        if(casaAtual == 0)
        { 
            if(Apertou == true)
            {
                StartCoroutine(MoviLerp(casas[casaAtual = 1], 5f));
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

        casaAtual++;

    }
}
