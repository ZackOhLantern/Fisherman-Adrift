using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolMove : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;

    public float runSpeed = 40f;

    //float horizontalMove = -1f;
    //bool jump = false;
    //bool crouch = false;
    public float runTime = 3.0f;
    float nextRunTime = 0f;
    float direction = 1f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("speed", Mathf.Abs(runSpeed));
        //Patrol Timing
        if (Time.time >= nextRunTime)
        {
            if (direction == -1f)
            {
                direction = 1f;
            }
            else
            {
                direction = -1f;
            }
            nextRunTime = Time.time + runTime;
        }

        //controller.Move(direction * runSpeed, false, false);

        //animator.SetFloat("speed", Mathf.Abs(horizontalMove));
    }
    void FixedUpdate()
    {
        controller.Move(direction * Time.fixedDeltaTime * runSpeed, false, false);
    }
}
