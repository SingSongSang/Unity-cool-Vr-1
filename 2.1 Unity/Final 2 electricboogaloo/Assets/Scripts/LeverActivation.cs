using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverActivation : MonoBehaviour
{
    Animator animator;
    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Sword")
        {
            animator.SetBool("IsFlipped", !animator.GetBool("IsFlipped"));
        }
    }
}
