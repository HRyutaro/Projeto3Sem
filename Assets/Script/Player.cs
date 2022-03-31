using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
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
        animator.SetFloat("MovingRight", velocity);
        animator.SetFloat("MovingLeft", velocity);
        animator.SetFloat("MovingBack", velocity);
        animator.SetFloat("DiagonalF", velocity);
        animator.SetFloat("DiagonalR", velocity);
        animator.SetFloat("DiagonalL", velocity);

        if (Input.GetKey(KeyCode.W))
        {

            if (Input.GetKey(KeyCode.LeftShift))
            {
                velocity = 2;
                speed = 7;
                transform.Translate(transform.forward * Time.deltaTime * speed);
                animator.SetFloat("Movingfoward", velocity);
                animator.SetFloat("DiagonalF", velocity);
            }
            else
            {
                velocity = 1;
                transform.Translate(transform.forward * Time.deltaTime * speed);
                animator.SetFloat("Movingfoward", velocity);
                animator.SetFloat("DiagonalF", velocity);
            }
        }
        if (Input.GetKey(KeyCode.S))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                velocity = 2;
                speed = 7;
                transform.Translate(-transform.forward * Time.deltaTime * speed);
                animator.SetFloat("MovingBack", velocity);
            }
            else
            {
                velocity = 1;
                transform.Translate(-transform.forward * Time.deltaTime * speed);
                animator.SetFloat("MovingBack", velocity);
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                velocity = 2;
                speed = 7;
                transform.Translate(transform.right * Time.deltaTime * speed);
                animator.SetFloat("MovingRight", velocity);
                animator.SetFloat("DiagonalR", velocity);
            }
            else
            {
                velocity = 1;
                transform.Translate(transform.right * Time.deltaTime * speed);
                animator.SetFloat("MovingRight", velocity);
                animator.SetFloat("DiagonalR", velocity);
            }
        }
        if (Input.GetKey(KeyCode.A))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                velocity = 2;
                speed = 7;
                transform.Translate(-transform.right * Time.deltaTime * speed);
                animator.SetFloat("MovingLeft", velocity);
                animator.SetFloat("DiagonalL", velocity);
            }
            else
            {
                velocity = 1;
                transform.Translate(-transform.right * Time.deltaTime * speed);
                animator.SetFloat("MovingLeft", velocity);
                animator.SetFloat("DiagonalL", velocity);
            }
        }
    }
}
