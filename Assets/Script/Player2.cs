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

    //game over
    public static bool gameOver = false;
    private bool Stop = false;

    //botao
    public static bool botaoAnim = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        gameOver = false;
        Stop = false;
        botaoAnim = false;
        
        
    }


    void Update()
    {
        //camera
        Direcao = new Vector3(InputX, 0, InputZ);

        //movimento
        InputX = Input.GetAxis("Horizontal");
        InputZ = Input.GetAxis("Vertical");
        
        if(Stop == false)
        {

            if (InputX == 0 || InputZ == 0)
        {
            anim.SetFloat("Movingfoward", 0);
            Velocidade = 5;
        }

            if (InputX != 0 || InputZ != 0)
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                Velocidade = 10;
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

            //pulo

        }

        //gameover

        if(gameOver == true)
        {
            StartCoroutine(FimdeJogo());
        }

        //botaoAnim
        if(botaoAnim == true)
        {
            anim.SetFloat("botao", 1);
        }

        //downStairs

        
    }
    //pulo    


    //gameOver
    public IEnumerator FimdeJogo()
    {
        Stop = true;
        anim.SetBool("GameOver", true);
        yield return new WaitForSeconds(2f);
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameOver");
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

}
