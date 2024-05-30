using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingAnimator : MonoBehaviour
{

    private Animator animator;
    private int walkState = 1;
    private bool walking = false;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            walking = true;
            animator.Play("Walking");
            walkState = 2;
        }
        else
        {
            walking = false;
            animator.Play("Waiting");
            walkState = 1;
        }
    }
}
