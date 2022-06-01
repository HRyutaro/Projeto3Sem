using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyGuard : MonoBehaviour
{
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

    //som
    public AudioSource[] somPasso;

    void Start()
    {
        //move
        stop = false;
        transform.position = casas[casaAtual];
        transform.rotation = roda [casaARotation];
        if(stop == false)
        {
            StartCoroutine(MoviLerp(casas[casaAtual+1],5f));
        }
        

        //animation
        {
            animator = GetComponent<Animator>();
            animator.SetFloat("Movingfoward", 1);
        }

        espada.SetActive(false);
    }


    void Update()
    {
        if(Player2.Deus == false)
        {
            //vision
            if (OnVision())
            {
                Player2.gameOver = true;
                stop = true;
                espada.SetActive(true);
                StartCoroutine("DrawSword");
                StopAllCoroutines();
            
            }

        }
      
    }
    
    IEnumerator DrawSword()
    {
        animator.SetBool("DrawSword", true);
        yield return new WaitForSeconds(3f);
        animator.SetBool("DrawSword", false);

    }

    public void PassoE()
    {
        if (!somPasso[0].isPlaying)
            somPasso[0].Play();
        else
            somPasso[1].Play();
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

        if(casaAtual == casaFinal)
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
        if(stop == false)
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

        if(angulo <= visionAngle && currentDis <= distanceMax)
        {
            if(Physics.Linecast(transform.position, Target.position,out hit))
            {
                if(hit.transform.tag == "Player")
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
}
