using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Vector3 playerPosition = new Vector3(0,0,0);

    string Starting = "player is very smelly";

    Rigidbody2D playerPhyiscs = null;

    

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Starting);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate((Input.GetAxisRaw("Horizontal")) *2 + (Time.deltaTime);
    }
}
