using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 200f;
    [SerializeField] private float jumpForce = 10f;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private Transform groundCheck;
    private bool isGrounded = false;
    private float moveInput;
    private Rigidbody2D rBody;

    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.1f, groundLayer);
        // Move left and right
        moveInput = Input.GetAxisRaw("Horizontal");
        rBody.linearVelocityX = moveInput * moveSpeed * Time.fixedDeltaTime;

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rBody.linearVelocityY = jumpForce;
        }
    }
}
