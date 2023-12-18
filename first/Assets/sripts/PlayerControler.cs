using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public float ScorePlayer { get; set; }
    public int CreditPlayer { get; set; }
    public float speed;
    public float jumpForce;
    public float moveInput;
    public Transform feetPos;
    public float checkRadius;
    public LayerMask whatIsGround;
    public Animator anim;
    public GameOverScreen gameOverScreen;
    public ObjectUp objectUp;

    private Rigidbody2D rb;
 
    private bool isGrounded;
    private bool facingRight = true;
    
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        CheckGrounded();
        HandleJump();
        UpdateAnimations();
        ScorePlayerData();
    }

    private void FixedUpdate()
    {
        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
        if (facingRight == false && moveInput > 0)
        {
            Flip();
        }
        if (facingRight == true && moveInput < 0)
        {
            Flip();
        }
        if (moveInput == 0)
        {
            anim.SetBool("isRunning", false);
        }
        else
        {
            anim.SetBool("isRunning", true);
        }
    }

    private void ScorePlayerData()
    {
        gameOverScreen.cred = CreditPlayer;
        gameOverScreen.score = ScorePlayer;
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;

        if (moveInput < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
        else if (moveInput > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
    }

    private void CheckGrounded()
    {
        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatIsGround);
    }

    private void HandleJump()
    {
        if (isGrounded == true && Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * jumpForce;
            anim.SetTrigger("takeOf");
        }

    }

    private void UpdateAnimations()
    {
        if (moveInput == 0)
        {
            anim.SetBool("isRunning", false);
        }
        else
        {
            anim.SetBool("isRunning", true);
        }
        if (isGrounded)
        {
            anim.SetBool("isJumping", false);
        }
        else
        {
            anim.SetBool("isJumping", true);
        }

    }
}
