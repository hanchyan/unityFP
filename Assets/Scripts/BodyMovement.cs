using UnityEngine;

public class BodyMovement : MonoBehaviour
{
    public float speed = 6f;
    Rigidbody rb;

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

        Vector3 move = transform.forward * v + transform.right * h;
        Vector3 targetPos = rb.position + move * speed * Time.fixedDeltaTime;

        rb.MovePosition(targetPos);
    }
}
