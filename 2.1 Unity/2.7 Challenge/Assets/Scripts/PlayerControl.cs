using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody2D rb;
    public Animator anim;
    public float speed = 2;
    public float jump = 300;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //getting the player input and moving
        transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal")*Time.deltaTime * speed,0, 0));

        //flipping and animating horizontal movement
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            transform.localScale = (new Vector3(5, 5, 0));
            anim.SetBool("Moving", true);
        }
        else if (Input.GetAxisRaw("Horizontal") < 0)
        {
            transform.localScale = (new Vector3(-5, 5, 0));
            anim.SetBool("Moving", true);
        }

        //if you dont press move dont use moving animation
        else
        {
            anim.SetBool("Moving", false);
        }


        //animation for jumping, also turns off walking animation 
        if (rb.velocity.y != 0)
        {
            anim.SetBool("Jumping", true);
            anim.SetBool("Moving", false);
        }
        else
        {
            anim.SetBool("Jumping", false);
        }
        if(rb.velocity.y == 0)
        {
            //Jumping Movement
            if (Input.GetKeyDown(KeyCode.W))
            {
                rb.AddForce(transform.up * jump);
            }
        }
    }
}
