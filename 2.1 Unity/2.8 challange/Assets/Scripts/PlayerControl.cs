using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    Rigidbody2D rb;
    Animator animator;
    public float speed;
    public float jumpHeight;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * Time.deltaTime*speed, 0, 0));
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            transform.localScale = (new Vector3(5,5,0));
            animator.SetBool("Moving", true);
        }
        else if (Input.GetAxisRaw("Horizontal") < 0)
        {
            transform.localScale = (new Vector3(-5, 5, 0));
            animator.SetBool("Moving", true);
        }
        else
        {
            animator.SetBool("Moving", false);
        }

        //jump code also makes it so you can only jump when on the ground
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (rb.velocity.y == 0)
            {
                rb.AddForce(transform.up*jumpHeight);
                animator.SetBool("Jumping", true);
            }
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            animator.SetBool("Jumping", false);
        }
        if (collision.gameObject.tag == "Death wall")
        {
            Debug.Log("Death");
        }
    }
}
