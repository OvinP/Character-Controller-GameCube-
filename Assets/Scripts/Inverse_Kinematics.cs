using UnityEngine;

public class SimpleLegIK : MonoBehaviour
{
    public Transform thigh;
    public Transform shin;
    public Transform foot;
    public Transform target;

    void LateUpdate()
    {
        // Aim thigh toward target
        Vector3 dir = target.position - thigh.position;
        thigh.rotation = Quaternion.LookRotation(dir, Vector3.up);

        // Aim shin toward target
        dir = target.position - shin.position;
        shin.rotation = Quaternion.LookRotation(dir, Vector3.up);

        // Snap foot to target rotation
        foot.position = target.position;
        foot.rotation = target.rotation;
    }
}

