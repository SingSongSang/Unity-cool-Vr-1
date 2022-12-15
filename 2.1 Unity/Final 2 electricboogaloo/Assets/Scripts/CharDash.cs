using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharDash : MonoBehaviour
{
    // Update is called clickTime = .2f;
    private const float doubleClickTime = .2f;

    private float lastClickTime;

    private bool canDash = true;

    private float dashingCooldown = 1;

    public float dashLength = 15;

    Rigidbody2D rb;

    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.D) && canDash)
        {
            float timeSincelastclick = Time.time - lastClickTime;
            lastClickTime = Time.time;
            if (timeSincelastclick < doubleClickTime)
            {
                StartCoroutine(rightDash());
                animator.SetTrigger("Dashing");
            }
        }

        if (Input.GetKeyDown(KeyCode.A) && canDash)
        {
            float timeSincelastclick = Time.time - lastClickTime;
            lastClickTime = Time.time;
            if (timeSincelastclick < doubleClickTime)
            {
                StartCoroutine(leftDash());
                animator.SetTrigger("Dashing");
            }

        }
    }
    private IEnumerator rightDash()
    {
        animator.SetBool("Jumping", false);
        canDash = false;
        rb.velocity = Vector2.right * dashLength;
        yield return new WaitForSecondsRealtime(dashingCooldown);
        canDash = true;
    }
    private IEnumerator leftDash()
    {
        animator.SetBool("Jumping", false);
        canDash = false;
        rb.velocity = Vector2.left * dashLength;
        yield return new WaitForSecondsRealtime(dashingCooldown);
        canDash = true;
    }
}
