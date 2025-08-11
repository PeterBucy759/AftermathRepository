using UnityEngine;

public class WASD : MonoBehaviour
{
    public float moveForce = 10f;

    private Rigidbody rb;
    private Vector3 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        // rb.drag = 1f; // Optional
    }

    void Update()
    {
        //float moveX = Input.GetAxisRaw("Horizontal");
        float moveZ = Input.GetAxisRaw("Vertical");

        // Create a local space movement vector
        movement = new Vector3(0f, 0f, moveZ).normalized;
    }

    void FixedUpdate()
    {
        // Convert local movement vector to world space based on rotation
        Vector3 localMovement = transform.TransformDirection(movement);

        rb.AddForce(localMovement * moveForce, ForceMode.Force);
    }
}
