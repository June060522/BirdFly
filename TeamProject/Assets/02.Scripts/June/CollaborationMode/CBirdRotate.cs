using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Dir
{
    left = 1,
    right = 2
}

public class CBirdRotate : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private Rigidbody2D rb2D;
    public Dir dir = Dir.right;

    float x = 0;
    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        rb2D = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        x = transform.position.x;
    }
    void Update()
    {
        if(x > transform.position.x && spriteRenderer.flipX == false)
        {
            dir = Dir.left;
            spriteRenderer.flipX = true;
            rb2D.velocity = new Vector2(0,rb2D.velocity.y);
        }
        else if(x < transform.position.x && spriteRenderer.flipX == true)
        {
            dir = Dir.right;
            spriteRenderer.flipX = false;
            rb2D.velocity = new Vector2(0,rb2D.velocity.y);
        }

        x = transform.position.x;
    }
}