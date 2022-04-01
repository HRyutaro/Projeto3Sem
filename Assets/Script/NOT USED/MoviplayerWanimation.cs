using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoviplayerWanimation : MonoBehaviour
{
    public float speed;
    Animator animator;
    private float velocity;

    void Start()
    {
        animator = GetComponent<Animator>();

    }

    void Update()
    {
        //movimento
        velocity = 0;
        speed = 5;
        animator.SetFloat("Movingfoward", velocity);
        animator.SetFloat("TurnRight", velocity);
        animator.SetFloat("TurnLeft", velocity);
        animator.SetFloat("MovingBack", velocity);
        animator.SetFloat("DiagonalF", velocity);
        animator.SetFloat("DiagonalR", velocity);
        animator.SetFloat("DiagonalL", velocity);

        if (Input.GetKey(KeyCode.W))
        {

            if (Input.GetKey(KeyCode.LeftShift))
            {
                velocity = 2;
                animator.SetFloat("Movingfoward", velocity);
                animator.SetFloat("DiagonalF", velocity);
            }
            else
            {
                velocity = 1;
                animator.SetFloat("Movingfoward", velocity);
                animator.SetFloat("DiagonalF", velocity);
            }
        }
        if (Input.GetKey(KeyCode.S))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                velocity = 2;
                animator.SetFloat("MovingBack", velocity);
            }
            else
            {
                velocity = 1;
                animator.SetFloat("MovingBack", velocity);
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                velocity = 2;
                animator.SetFloat("TurnRight", velocity);
                animator.SetFloat("DiagonalR", velocity);
            }
            else
            {
                velocity = 1;
                animator.SetFloat("TurnRight", velocity);
                animator.SetFloat("DiagonalR", velocity);
            }
        }
        if (Input.GetKey(KeyCode.A))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                velocity = 2;
                animator.SetFloat("TurnLeft", velocity);
                animator.SetFloat("DiagonalL", velocity);
            }
            else
            {
                velocity = 1;
                animator.SetFloat("TurnLeft", velocity);
                animator.SetFloat("DiagonalL", velocity);
            }
        }
    }
}
