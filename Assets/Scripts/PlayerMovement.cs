using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private float direction = 0f;
    
    [SerializeField]
    private float moveSpeed = 7f;

    [SerializeField] 
    private float jumpSpeed = 14f;
    
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        direction = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(direction * moveSpeed, rb.velocity.y);
        
        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
        }
    }
}
