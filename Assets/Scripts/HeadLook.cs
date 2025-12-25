using UnityEngine;

public class HeadLook : MonoBehaviour
{
    public float lookSpeed = 80f;
    float xRotation = 0f;
    float yRotation = 0f;

    void Update()
{
    float lookX = 0f;
    float lookY = 0f;

    if (Input.GetKey(KeyCode.LeftArrow)) lookX = -1f;
    if (Input.GetKey(KeyCode.RightArrow)) lookX = 1f;
    if (Input.GetKey(KeyCode.UpArrow)) lookY = 1f;
    if (Input.GetKey(KeyCode.DownArrow)) lookY = -1f;

    xRotation -= lookY * lookSpeed * Time.deltaTime;
    xRotation = Mathf.Clamp(xRotation, -80f, 80f);

    yRotation += lookX * lookSpeed * Time.deltaTime;

    transform.localRotation = Quaternion.Euler(xRotation, yRotation, 0f);
}
}
