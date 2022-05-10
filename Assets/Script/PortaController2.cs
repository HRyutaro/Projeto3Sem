using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortaController2 : MonoBehaviour
{
    private int casaAtual = 0;
    private int casaARotation = 0;
    public Vector3[] casas = new Vector3[2];
    public Quaternion[] roda = new Quaternion[2];
    public int casaFinal;
    public int casaFinalR;
    public static bool podeAbrir;



    void Start()
    {
        podeAbrir = false;
    }


    void Update()
    {
        if(podeAbrir == true)
        {
            StartCoroutine(MoviLerp(casas[casaAtual = 1], 5f));
            StartCoroutine(MoviRotationLerp(roda[casaARotation = 1], 5f));
        }
    }


    IEnumerator MoviRotationLerp(Quaternion targetPosition, float duration)
    {
        float time = 0;
        Quaternion startPosition = transform.rotation;
        while (time < duration)
        {
            transform.rotation = Quaternion.Lerp(startPosition, targetPosition, time / duration);
            time += Time.deltaTime;
            yield return null;
        }
        transform.rotation = targetPosition;

        casaARotation++;

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
