using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    float walkDir;
    Rigidbody2D rb;
    readonly float walkSpeed = 2;
    readonly float jumpHeight = 6;
    Collider2D col;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent<Collider2D>();
    }
    public void Walk(InputAction.CallbackContext context)
    {
        walkDir = context.ReadValue<float>();
    }
    private void Update()
    {
        if (rb != null)
        {
            rb.velocity = new(walkSpeed * walkDir, rb.velocity.y);
        }
    }
    public void Jump(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            if (Physics2D.Raycast(col.bounds.center, Vector2.down, col.bounds.extents.y + 0.1f))
            {
                rb.velocity = new(rb.velocity.x, jumpHeight);
            }
        }
    }
}
