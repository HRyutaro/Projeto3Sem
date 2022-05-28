using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    //Vida
    public static int Vida;
    public GameObject Vida1;
    public GameObject Vida2;
    public GameObject Vida3;


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
    public static bool Stop = false;

    //botao
    public static bool botaoAnim = false;

    //combat
    public static bool OnCombat;
    public static bool OffCombat;

    private GameObject inimigo;
    //Anim Combat
    public static bool Ataque;
    public static bool Hit;

    //som
    public AudioSource[] somPasso;
    public AudioSource[] somPassoCorrer;

    void Start()
    {

        Vida = 3;
        Vida1.SetActive(true);
        Vida2.SetActive(true);
        Vida3.SetActive(true);

        rb = GetComponent<Rigidbody>();
        gameOver = false;
        Stop = false;
        botaoAnim = false;
        OnCombat = false;
        inimigo = GameObject.FindWithTag("Guardfoco");

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


        }

        if(Stop == true)
        {
            anim.SetFloat("Movingfoward", 0);
        }
        //gameover
        if (Vida == 2)
        {
            Vida3.SetActive(false);
        }
        if (Vida == 1)
        {
            Vida2.SetActive(false);
        }
        if (Vida == 0)
        {
            Vida1.SetActive(false);
            gameOver = true;
        }


        if(gameOver == true)
        {
            StartCoroutine(FimdeJogo());
        }

        //botaoAnim
        if(botaoAnim == true)
        {
            anim.SetFloat("botao", 1);
        }

        //Combat
        if(OnCombat == true)
        {
            StartCoroutine(onCombat());
        }
        if(OffCombat == true)
        {
            StartCoroutine(offCombat());           
        }
        
        //animCombat
        if(Ataque == true)
        {
            StartCoroutine("AnimAtaque");
            Ataque = false;
        }

        if(Hit == true)
        {
            if(gameOver == false)
            {
                StartCoroutine("AnimHit");
                Hit = false;
            }
        }

    }

    //som
    public void Passo()
    {
        if (!somPasso[0].isPlaying)
            somPasso[0].Play();
        else
            somPasso[1].Play();
    }
    public void PassoCorrer()
    {
        if (!somPassoCorrer[0].isPlaying)
            somPassoCorrer[0].Play();
        else
            somPassoCorrer[1].Play();
    }

    //gameOver
    public IEnumerator FimdeJogo()
    {
        Stop = true;
        if(MenuInicial.faseAtual == 2)
        {
            anim.SetBool("GameOver2", true);
        }
        else
        {
            anim.SetBool("GameOver", true);
        }
        CameraController.lockCursor = false;
        yield return new WaitForSeconds(3f);
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameOver");
        
    }

    public IEnumerator onCombat()
    {
        anim.SetBool("Battle", true);
        Stop = true;
        yield return new WaitForSeconds(1f);
        OnCombat = false;
    }

    public IEnumerator offCombat()
    {
        anim.SetBool("Battle", false);
        Stop = false;
        yield return new WaitForSeconds(1f);
        OffCombat = false;
    }

    IEnumerator AnimAtaque()
    {
        anim.SetBool("Ataque1",true);
        yield return new WaitForSeconds(1.5f);
        anim.SetBool("Ataque1",false);
        
    }

    IEnumerator AnimHit()
    {
        yield return new WaitForSeconds(0.8f);
        anim.SetBool("TomandoHit", true);
        yield return new WaitForSeconds(0.5f);
        anim.SetBool("TomandoHit", false);
    }


}
