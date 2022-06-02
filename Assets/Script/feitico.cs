using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class feitico : MonoBehaviour
{
    public float speed;
    void Start()
    {
        
    }


    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        Destroy(gameObject ,1f);
    }
}
