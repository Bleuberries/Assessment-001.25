using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f; // speed of movement 
    public float jumpForce = 8f; // jump strength
    private float moveInput; 
    private bool isGrounded; 
    private Rigidbody2D rb;
    private Animator animator; //Reference to animator 
    public Transform groundCheck; 
    public LayerMask groundLayer;

    
   
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // get Rigidbody component
        animator = GetComponent<Animator>(); //Get Animator component
    }

    void Update()
    {
        //Get left and right input 
        moveInput = Input.GetAxis("Horizontal"); 

        //Flip sprite direction based on movement
        if (moveInput > 0)
            transform.localScale = new Vector3(1, 1, 1);
        else if (moveInput < 0)
            transform.localScale = new Vector3(-1, 1, 1);
        
        //Jumping logic
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }

        //Update animaton parameters
        animator.SetFloat("Speed", Mathf.Abs(moveInput));
        animator.SetBool("isGrounded", isGrounded);
    }

    void FixedUpdate()
    {
        // move left and right
        rb.linearVelocity = new Vector2(moveInput * speed, rb.linearVelocity.y); 

        //check if the player is on the ground
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);

        //Debug to check if GroundCheck is working
        Debug.Log("IsGrounded: " + isGrounded);
    }
}
