using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float horizontal;
    private bool isFacingRight = true;
    [SerializeField] private float speed = 8f;
    [SerializeField] private float jumpForce = 10f;
    [SerializeField] public Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    public Animator animator;
    public SpriteRenderer spriteRenderer;
    public static PlayerMovement instance;
    
    
    public void Awake()
    {
        instance = this;

    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }

        if (Input.GetButtonUp("Jump") && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.4f);
        }

        Flip();

        float characterVelocity = Mathf.Abs(rb.velocity.x);
        animator.SetFloat("Speed", characterVelocity);

        Flip(rb.velocity.x);
    }

    private void FixedUpdate() 
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);    
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            transform.localScale = localScale;
        }
    }

    void Flip(float _velocity)
    {
        if(_velocity > 0.1f)
        {
          spriteRenderer.flipX = false;
        }else if(_velocity < -0.1f) 
        {
          spriteRenderer.flipX = true;    
        }
    }
}
