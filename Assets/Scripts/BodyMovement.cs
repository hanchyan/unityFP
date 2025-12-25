using UnityEngine;

public class BodyMovement : MonoBehaviour
{
    public float speed = 6f;
    Rigidbody rb;

    public Transform head; // assign the Head transform in Inspector

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float h = 0f;
        float v = 0f;

        if (Input.GetKey(KeyCode.A)) h = -1f;
        if (Input.GetKey(KeyCode.D)) h = 1f;
        if (Input.GetKey(KeyCode.W)) v = 1f;
        if (Input.GetKey(KeyCode.S)) v = -1f;

        // Build movement relative to head orientation
        Vector3 forward = head.forward;
        forward.y = 0; // flatten so we don’t move up/down
        forward.Normalize();

        Vector3 right = head.right;
        right.y = 0;
        right.Normalize();

        Vector3 move = forward * v + right * h;

        rb.MovePosition(rb.position + move * speed * Time.fixedDeltaTime);
    }
}
