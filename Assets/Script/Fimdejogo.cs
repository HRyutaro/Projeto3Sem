using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fimdejogo : MonoBehaviour
{
    public GameObject Epilogo;
    public GameObject Creditos;
    void Start()
    {
        Epilogo.SetActive(true);
        Creditos.SetActive(false);
    }


    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            Epilogo.SetActive(false);
            Creditos.SetActive(true);
        }
    }
}
