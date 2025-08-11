using UnityEngine;

public class LRUD : MonoBehaviour
{
    public float torqueForce = 10f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate() // Use FixedUpdate for physics
    {
        float torqueX = 0f;
        float torqueY = 0f;
        float torqueZ = 0f;

        if (Input.GetKey(KeyCode.UpArrow))
            torqueX = 1f;
        if (Input.GetKey(KeyCode.DownArrow))
            torqueX = -1f;

        if (Input.GetKey(KeyCode.A))
            torqueY = -1f;
        if (Input.GetKey(KeyCode.D))
            torqueY = 1f;

        if (Input.GetKey(KeyCode.LeftArrow))
            torqueZ = 1f;
        if (Input.GetKey(KeyCode.RightArrow))
            torqueZ = -1f;

        // Apply torque to rotate with physics
        Vector3 torque = new Vector3(torqueX, torqueY, torqueZ) * torqueForce;
        rb.AddRelativeTorque(torque);
    }
}
