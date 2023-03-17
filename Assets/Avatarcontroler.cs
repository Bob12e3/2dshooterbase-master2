using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avatarcontroler : MonoBehaviour
{

    [SerializeField]
    Transform groundChecker;

    [SerializeField]
    float jumpForce = 100;

    [SerializeField]
    float speed = 5f;

    [SerializeField]
    LayerMask groundLayer;

    Rigidbody2D rb;

    bool hasRealesedJump = true;
    bool isGrounded = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {

        isGrounded = Physics2D.OverlapCircle(groundChecker.position, 0.3f, groundLayer);
        
 
        if (Input.GetAxisRaw("Jump") > 0 && hasRealesedJump && isGrounded == true)
        {
            print("JUMP");
            rb.AddForce(Vector2.up * jumpForce);
            hasRealesedJump = false;
        }
        else if (Input.GetAxisRaw("Jump") == 0)
        {
            hasRealesedJump = true;
        }

        float xMove = Input.GetAxisRaw("Horizontal");
        

        Vector2 movement = new Vector2(xMove, 0) * speed * Time.deltaTime;

        transform.Translate(movement);
    }
}
