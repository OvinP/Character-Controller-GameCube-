using UnityEngine;

public class SimpleStep : MonoBehaviour
{
    public Transform foot;
    public Transform target;
    public float stepDistance = 0.5f;
    public float stepSpeed = 5f;

    private bool stepping = false;
    private Vector3 oldPos;
    private Vector3 newPos;
    private float lerp = 0f;

    void Update()
    {
        float dist = Vector3.Distance(foot.position, target.position);

        if (!stepping && dist > stepDistance)
        {
            stepping = true;
            lerp = 0f;
            oldPos = foot.position;
            newPos = target.position;
        }

        if (stepping)
        {
            lerp += Time.deltaTime * stepSpeed;
            foot.position = Vector3.Lerp(oldPos, newPos, lerp);

            if (lerp >= 1f)
                stepping = false;
        }
    }
}
