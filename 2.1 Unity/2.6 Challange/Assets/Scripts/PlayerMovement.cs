using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Vector2 xMove;
    Transform player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        xMove = new Vector2(1, 0);
        player = gameObject.transform;
        transform.Translate(xMove * Time.deltaTime);
    }
}
