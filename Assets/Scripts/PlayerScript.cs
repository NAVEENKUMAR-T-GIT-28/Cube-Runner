using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float sideMoveSpeed = 10f;
    public float forwardMoveSpeed = 15f;

    public float maxX;
    public float minX;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        maxX = 4.5f;
        minX = -4.5f;
    }

    void FixedUpdate()
    {
        float x = Input.GetAxisRaw("Horizontal");

        rb.linearVelocity = new Vector3(
            x * sideMoveSpeed,
            rb.linearVelocity.y,
            forwardMoveSpeed
        );
    }

    void Update()
    {
        Vector3 playerPos = transform.position;

        playerPos.x = Mathf.Clamp(
            playerPos.x,
            minX,
            maxX
        );

        transform.position = playerPos;
    }
}