using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AcornCount : MonoBehaviour
{
    static public float lives = 3;
    static public float acornCount = 0;
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
            SceneManager.LoadScene(0);
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
            SceneManager.LoadScene(0);
        }
        if (collision.gameObject.tag == "Door")
        {
            if (acornCount == 11)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            else
            {
                SceneManager.LoadScene(0);
            }

        }
    }
    
}
