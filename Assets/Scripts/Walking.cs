using UnityEngine;

public class PuppetMovement : MonoBehaviour
{
    public Rigidbody hips;
    public float leanForce = 150f;

    void FixedUpdate()
    {
        float v = Input.GetAxis("Vertical");   // forward/back
        float h = Input.GetAxis("Horizontal"); // left/right

        // Lean direction
        Vector3 leanDir = new Vector3(h, 0, v);

        // Apply torque to hips
        hips.AddTorque(transform.right * -v * leanForce);
        hips.AddTorque(transform.forward * h * leanForce);
    }
}
