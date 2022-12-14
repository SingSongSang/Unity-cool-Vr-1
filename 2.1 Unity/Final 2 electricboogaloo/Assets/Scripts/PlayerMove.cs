using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Rigidbody2D rb;
    Animator animator;
    static public float speed = 3.5f;
    public float jumpHeight = 100;
    public PlayerAttack playerAttack;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        // moving code
        transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * Time.deltaTime * speed, 0, 0));
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            transform.localScale = (new Vector3(3, 3, 0));
            animator.SetBool("Moving", true);
        }
        else if (Input.GetAxisRaw("Horizontal") < 0)
        {
            transform.localScale = (new Vector3(-3, 3, 0));
            animator.SetBool("Moving", true);
        }
        else
        {
            animator.SetBool("Moving", false);
        }

        //Jumping Code
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (rb.velocity.y == 0)
            {
                rb.velocity = Vector2.up * jumpHeight;
                animator.SetBool("Jumping", true);
            }
        }


        //Attack Animation
        if (Input.GetMouseButtonDown(0))
        {
            animator.SetBool("Attacking", true);
        }
        else
        {
            animator.SetBool("Attacking", false);

        } 
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Jump Animation end
        if (collision.gameObject.tag == "Ground")
        {
            animator.SetBool("Jumping", false);
        }
    }
}
