using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{

    //movimento
    float InputX;
    float InputZ;
    public float Velocidade;
    public Animator anim;

    //Camera
    Vector3 Direcao;
    public Camera MainCamera;

    //pulo
    public float JumpForce;
    private Rigidbody rb;
    private bool jumping;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {      
        //camera
        Direcao = new Vector3(InputX, 0, InputZ);

        //movimento
        InputX = Input.GetAxis("Horizontal");
        InputZ = Input.GetAxis("Vertical");

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

        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(jump());
        }

    }
    //pulo
    
    IEnumerator jump()
    {
        if (jumping == false)
        {
            rb.velocity = new Vector3(rb.velocity.x, JumpForce, rb.velocity.z);
            anim.SetFloat("Jumping", 1);
            jumping = true;
            yield return new WaitForSeconds(1f);
            anim.SetFloat("Jumping", 0);
            jumping = false;
            print(jumping);
        }

    }
}
