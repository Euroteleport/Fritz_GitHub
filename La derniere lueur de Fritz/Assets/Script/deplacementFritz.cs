using UnityEngine;

public class deplacementFritz : MonoBehaviour
{
    public float moveSpeed;
    public float jumpForce;
    public bool isJumping;
    public Rigidbody2D rb;
    public Animator animator;
    public SpriteRenderer spriteRenderer;
    
    private Vector3 velocity = Vector3.zero;

  
    void FixedUpdate()
    {
        float horizontalMovement = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
         
         if(Input.GetButtonDown("Jump"))
         {
            Debug.Log("jump");
            isJumping = true;
         }
             
    
         MovePlayer(horizontalMovement);

         flip(rb.velocity.x);

         float characterVelocity = Mathf.Abs(rb.velocity.x);
         animator.SetFloat("Speed", characterVelocity);
    }

    void MovePlayer(float _horizontalMovement)
    {
        Vector3 targetVelocity = new Vector2(_horizontalMovement, rb.velocity.y);
        rb.velocity =  Vector3.SmoothDamp(rb.velocity, targetVelocity, ref velocity, .05f);

        if(isJumping == true)
        {
            rb.AddForce(new Vector2(0f, jumpForce));
            isJumping = false;
        }
    }

    void flip(float _velocity)
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


