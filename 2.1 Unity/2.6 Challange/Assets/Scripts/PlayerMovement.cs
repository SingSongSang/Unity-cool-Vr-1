using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //speed modifier
    public float speed = 2;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = (new Vector3((Input.GetAxisRaw("Horizontal")) * speed, (Input.GetAxisRaw("Vertical")) * speed, 0));
        Vector2 flip = new Vector3(-1, 1 , 1);
        transform.localScale *= flip;
        /*if (Input.GetAxisRaw("Horizontal") < 0)
         {
             transform.localScale = new Vector3(-5, 5, 0);
         }
         if (Input.GetAxisRaw("Horizontal")> 0)
         {
             transform.localScale = new Vector3(5, 5, 0);
         }*/
    }

}
