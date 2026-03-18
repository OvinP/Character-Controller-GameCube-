using UnityEngine;
using UnityEngine.InputSystem;

public class LegController : MonoBehaviour
{
    public Rigidbody legRb;
    public InputActionReference swingAction;
    public float torqueStrength = 150f;

    void OnEnable()
    {
        swingAction.action.Enable();
    }

    void OnDisable()
    {
        swingAction.action.Disable();
    }

    void FixedUpdate()
    {
        float input = swingAction.action.ReadValue<float>();
        legRb.AddTorque(transform.right * input * torqueStrength, ForceMode.Force);
    }
}

