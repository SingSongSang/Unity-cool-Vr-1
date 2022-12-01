using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AcornCount : MonoBehaviour
{
    public float lives = 3;
    public float acornCount;
    public Text acornsAquired;
    public Text LIVES;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        acornsAquired.text = "Acorns : "+ acornCount;
        LIVES.text = "Lives :"+ lives;
        if (lives == 0)
        {
            Debug.Log("Death");
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Accorn")
        {
            acornCount += 1;
        }
        if (collision.gameObject.tag == "Enemy")
        {
            lives -= 1;
        }
        if (collision.gameObject.tag == "Death wall")
        {
            lives = 0;
        }
        if (collision.gameObject.tag == "Door")
        {
            SceneManager.LoadScene(2);
        }
    }
    
}
