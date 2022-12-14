using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public Collider2D swordCollider;
    public float damage = 3;
    Vector2 rightAttackOffset;

    private void Start()
    {
        rightAttackOffset = transform.position;
    }

    public void StartAttack()
    {
        swordCollider.enabled = true;
    }


    public void StopAttack()
    {
        swordCollider.enabled = false;
    }

    /*private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            // Deal damage to the enemy
            Enemy enemy = other.GetComponent<Enemy>();

            if (enemy != null)
            {
                enemy.Health -= damage;
            }
        }
    }*/
}
