using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //speed modifier
    public Animator animator;
    public float speed = 2;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = (new Vector3((Input.GetAxisRaw("Horizontal")) * speed, (Input.GetAxisRaw("Vertical")) * speed, 0));
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            animator.SetBool("Moving", true);
            transform.localScale = new Vector3(-5, 5, 0);
        }
        else if (Input.GetAxisRaw("Horizontal") > 0)
        {
            animator.SetBool("Moving", true);
            transform.localScale = new Vector3(5, 5, 0);
        }
        else
        {
            animator.SetBool("Moving", false);
        }

    }

}
