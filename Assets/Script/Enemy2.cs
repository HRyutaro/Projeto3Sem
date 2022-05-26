using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    //VidaInimigo
    public int VidaInimigo;

    //vision
    public Transform Target;
    public float visionAngle = 90;
    public float distanceMax = 10;
    public bool lockCursor;

    //move
    private int casaAtual = 0;
    private int casaARotation = 0;
    public Vector3[] casas = new Vector3[2];
    public Quaternion[] roda = new Quaternion[2];
    public int casaFinal;
    public int casaFinalR;
    private bool stop = false;

    //animation
    public Animator animator;
    public GameObject espada;
    public static bool atacandoI;

    //Sound
    //public AudioSource somPasso;

    public bool oncombat;

    public GameObject player;

    public static bool DeuDano;
    public static bool DeuDano2;

    void Start()
    {

        //move
        stop = false;
        transform.position = casas[casaAtual];
        transform.rotation = roda[casaARotation];
        if (stop == false)
        {
            StartCoroutine(MoviLerp(casas[casaAtual + 1], 5f));
        }

        //animation
        {
            animator = GetComponent<Animator>();
            animator.SetFloat("Movingfoward", 1);
            espada.SetActive(false);
        }

    }


    void Update()
    {

        //vision
        if (oncombat == false)
        {
            if (OnVision())
            {

                olhar();
                hudcombaton();

                espada.SetActive(true);

                stop = true;
                StopAllCoroutines();
                StartCoroutine("animCombatidle");
                

                oncombat = true;
            }

        }

        //animataque
        if (atacandoI == true)
        {
            StartCoroutine("animAtaque");
            atacandoI = false;
        }

        //dano
        if (DeuDano == true)
        {
            Dano(1);
            StartCoroutine("ReceberDano");
        }
        if (DeuDano2 == true)
        {
            Dano(2);
            StartCoroutine("ReceberDano");
        }
    }

    //movimento
    IEnumerator MoviLerp(Vector3 targetPosition, float duration)
    {

        float time = 0;
        Vector3 startPosition = transform.position;
        while (time < duration)
        {
            transform.position = Vector3.Lerp(startPosition, targetPosition, time / duration);
            time += Time.deltaTime;
            yield return null;
        }
        transform.position = targetPosition;

        casaAtual++;

        if (casaAtual == casaFinal)
        {
            casaAtual = -1;

        }
        if (stop == false)
        {
            StartCoroutine(MoviRotationLerp(roda[casaARotation + 1], 1.5f));
        }


    }

    IEnumerator MoviRotationLerp(Quaternion targetPosition, float duration)
    {
        animator.SetFloat("turn", 1);
        float time = 0;
        Quaternion startPosition = transform.rotation;
        while (time < duration)
        {
            transform.rotation = Quaternion.Lerp(startPosition, targetPosition, time / duration);
            time += Time.deltaTime;
            yield return null;
        }
        transform.rotation = targetPosition;

        casaARotation++;

        if (casaARotation == casaFinalR)
        {
            casaARotation = -1;

        }
        if (stop == false)
        {
            StartCoroutine(MoviLerp(casas[casaAtual + 1], 5f));
        }
        animator.SetFloat("turn", 0);
    }

    //vision
    bool OnVision()
    {
        Vector3 dir = Target.position - transform.position;
        float angulo = Vector3.Angle(dir, transform.forward);

        float currentDis = Vector3.Distance(Target.position, transform.position);

        RaycastHit hit;

        if (angulo <= visionAngle && currentDis <= distanceMax)
        {
            if (Physics.Linecast(transform.position, Target.position, out hit))
            {
                if (hit.transform.tag == "Player")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }
    
    //animação combat
    IEnumerator animAtaque()
    {
        animator.SetBool("Ataque",true);
        yield return new WaitForSeconds(1f);
        animator.SetBool("Ataque",false);
    }
    IEnumerator animCombatidle()
    {
        animator.SetBool("DrawSword", true);
        yield return new WaitForSeconds(1f);
        animator.SetFloat("Movingfoward", 0);
        animator.SetBool("DrawSword", false);

    }
    IEnumerator ReceberDano()
    {
        yield return new WaitForSeconds(1f);
        animator.SetTrigger("ReceberDano");
        yield return new WaitForSeconds(1f);
        animator.SetTrigger("ReceberDano");
    }
    IEnumerator Morte()
    {
        yield return new WaitForSeconds(1f);
        animator.SetTrigger("Morte");
    }

    //combat
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "AreaAtaque")
        {
            StartCoroutine("Morte");
            Destroy(gameObject, 5f);
        }
    }

    void olhar()
    {
        transform.LookAt(player.transform.position);
        player.transform.LookAt(gameObject.transform.position);
    }

    void hudcombaton()
    {
        Player2.OnCombat = true;
        CombatConfig.HudCombatOn = true;
    }

    void Dano(int x)
    {
        if (x == 1)
        {
            VidaInimigo -= 1;
            DeuDano = false;
        }
        if (x == 2)
        {
            VidaInimigo -= 2;
            DeuDano2 = false;
        }

    }
}
