using UnityEngine;

public class SimpleBalance : MonoBehaviour
{
    public Rigidbody hips;
    public float uprightStrength = 500f;
    public float uprightDamping = 50f;

    void FixedUpdate()
    {
        if (hips == null) return;

        // Desired upright rotation
        Quaternion targetRot = Quaternion.Euler(0, hips.rotation.eulerAngles.y, 0);

        // Calculate torque to rotate hips toward upright
        Quaternion delta = targetRot * Quaternion.Inverse(hips.rotation);
        delta.ToAngleAxis(out float angle, out Vector3 axis);

        if (angle > 180f) angle -= 360f;

       

        Vector3 torque = axis * (angle * uprightStrength) - hips.angularVelocity * uprightDamping;

        hips.AddTorque(torque);
    }
}


