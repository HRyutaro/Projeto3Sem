using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ending : MonoBehaviour
{
    public GameObject Player;
    public GameObject PlayerRun;
    private bool podeApertar;
    private bool jaApertou;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(EndingZone());

        }

    }

    IEnumerator EndingZone()
    {
        PlayerRun.SetActive(true);
        Player.SetActive(false);
        MenuInicial.faseAtual = 2;
        yield return new WaitForSeconds(3f);
        PlayerRun.SetActive(false);
        UnityEngine.SceneManagement.SceneManager.LoadScene("Fase 2");

    }
}
