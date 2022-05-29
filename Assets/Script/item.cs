using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour
{

    public GameObject carta;
    public GameObject intereção;

    //rotação
    private int casaAtual = 0;
    private int casaARotation = 0;
    public Vector3[] casas = new Vector3[2];
    public Quaternion[] roda = new Quaternion[2];
    public int casaFinal;
    public int casaFinalR;

    void Start()
    {
        carta.SetActive(false);
        intereção.SetActive(false);
        transform.position = casas[casaAtual];
        transform.rotation = roda[casaARotation];
    }

    void Update()
    {
        StartCoroutine(MoviLerp(casas[casaAtual + 1], 5f));
        StartCoroutine(MoviRotationLerp(roda[casaARotation + 1], 5f));
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Config.PagNumero++;
            intereção.SetActive(true);
            carta.SetActive(true);
            Destroy(gameObject, 0.1f);
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

        if (casaAtual == casaFinal)
        {
            casaAtual = -1;

        }
        StartCoroutine(MoviLerp(casas[casaAtual + 1], 5f));
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

        if (casaARotation == casaFinalR)
        {
            casaARotation = -1;
        }
        StartCoroutine(MoviRotationLerp(roda[casaARotation + 1], 5f));
    }
}
