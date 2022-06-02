using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magia : MonoBehaviour
{
    public float speed;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * speed);
    }
}
