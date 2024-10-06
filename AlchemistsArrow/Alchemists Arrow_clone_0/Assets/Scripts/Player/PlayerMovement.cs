using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    public KeyCode jumpKey = KeyCode.C;

    float currentSpeed;
    public float baseSpeed = 10f;

    public float jumpPower;
    public bool grounded;

    Vector2 input;

    void Start()
    {
        
    }

    void Update()
    {
        input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(input.x, rb.velocity.y);

        if (Input.GetKeyDown(jumpKey) && grounded)
        {
            Jump();
        }
    }
    void Jump()
    {
        rb.AddForce(new Vector2(0, jumpPower), ForceMode2D.Impulse);
    }
}
