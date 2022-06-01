using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour
{

    public GameObject carta;
    public GameObject intereção;

    //rotação
    private int casaARotation = 0;
    public Quaternion[] roda = new Quaternion[2];
    public int casaFinalR;

    void Start()
    {
        carta.SetActive(false);
        intereção.SetActive(false);
        transform.rotation = roda[casaARotation];
    }

    void Update()
    {
        StartCoroutine(MoviRotationLerp(roda[casaARotation + 1], 1f));
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
        StartCoroutine(MoviRotationLerp(roda[casaARotation + 1], 1f));
    }
}
