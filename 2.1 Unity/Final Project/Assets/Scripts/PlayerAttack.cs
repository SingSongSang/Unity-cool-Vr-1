using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public BoxCollider2D SwordCollider;
    Vector2 HitboxOffset;
    // Start is called before the first frame update
    void Start()
    {
        SwordCollider = GetComponent<BoxCollider2D>();
        HitboxOffset = transform.position;
    }

    public void StartAttack()
    {
        SwordCollider.enabled = true;
    }
    public void StopAttack()
    {
        SwordCollider.enabled = false;
    }
}
