using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGuardIdle : MonoBehaviour
{
    //vision
    public Transform Target;
    public float visionAngle = 50;
    public float distanceMax = 11;
    public bool lockCursor;
    

    //animation
    public Animator animator;

    void Start()
    {
        //animation
        animator = GetComponent<Animator>();
        animator.SetFloat("Movingfoward", 1);

    }


    void Update()
    {
        if (OnVision())
        {
            Player2.gameOver = true;
            animator.SetBool("DrawSword", true);
        }
    }

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
}
