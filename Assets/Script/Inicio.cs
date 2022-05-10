using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inicio : MonoBehaviour
{
    public GameObject Player;
    public GameObject PlayerRun;
    public GameObject CameraMain;
    public GameObject CameraCutscene;


    void Start()
    {
            StartCoroutine(BeginZone());
        
    }


    void Update()
    {
        
    }

    IEnumerator BeginZone()
    {
        CameraMain.SetActive(false);
        CameraCutscene.SetActive(true);
        PlayerRun.SetActive(true);
        Player.SetActive(false);
        yield return new WaitForSeconds(3f);
        CameraCutscene.SetActive(false);
        CameraMain.SetActive(true);
        yield return new WaitForSeconds(1f);
        PlayerRun.SetActive(false);
        Player.SetActive(true);

    }
}
