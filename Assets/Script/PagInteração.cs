using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PagInteração : MonoBehaviour
{
    public GameObject[] Pags;


    void Start()
    {
        
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Pags[0].SetActive(false);
            Pags[1].SetActive(false);
            Pags[2].SetActive(false);
            gameObject.SetActive(false);
        }
    }
}
