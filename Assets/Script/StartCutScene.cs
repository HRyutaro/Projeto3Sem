using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCutScene : MonoBehaviour
{
    public GameObject Player;
    public GameObject PlayerCutscene;
    bool Usado;

    void Start()
    {
        Usado = false;
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(Usado == false)
        {
            StartCoroutine(CutScene());
            Usado = true;
        }
    }

    IEnumerator CutScene()
    {
        Player.SetActive(false);
        PlayerCutscene.SetActive(true);
        yield return new WaitForSeconds(6.8f);
        Player.SetActive(true);
        PlayerCutscene.SetActive(false);
    }

}
