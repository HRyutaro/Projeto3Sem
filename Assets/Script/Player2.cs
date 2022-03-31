using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    public float Velocidade;
    public Animator anim;

    float InputX;
    float InputZ;
    Vector3 Direcao;

    public Camera MainCamera;
    public float VelocidadeCamera;
    public float VelocidadeRotacaoCamera;
    public Vector3 CameraOffset;

    void Start()
    {
        
    }


    void Update()
    {
        InputX = Input.GetAxis("Horizontal");
        InputZ = Input.GetAxis("Vertical");
        Direcao = new Vector3(InputX, 0, InputZ);
        var pos = transform.position - MainCamera.transform.forward * CameraOffset.z
                  + MainCamera.transform.up * CameraOffset.y + MainCamera.transform.right * CameraOffset.x;

        if (InputX == 0 || InputZ == 0)
        {
            anim.SetFloat("Movingfoward", 0);
            Velocidade = 5;
        }

        if (InputX != 0 || InputZ != 0)
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                Velocidade = 15;
                var camrot = MainCamera.transform.rotation;
                camrot.x = 0;
                camrot.z = 0;

                transform.Translate(0, 0, Time.deltaTime * Velocidade);
                anim.SetFloat("Movingfoward", 2);
                transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(Direcao) * camrot, 2 * Time.deltaTime);
            }
            else
            {
              var camrot = MainCamera.transform.rotation;
              camrot.x = 0;
              camrot.z = 0;

              transform.Translate(0, 0, Time.deltaTime * Velocidade);
              anim.SetFloat("Movingfoward", 1);
              transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(Direcao) * camrot, 2 * Time.deltaTime);
            }

        }

}
}
