
using UnityEngine;

public class camerafollow : MonoBehaviour
{
    public Transform target;

    public float smoothspeed = 0.125f;
    public Vector3 offset;

    void FixedUpdate()
    {
        Vector3 desiredposition = target.position + offset;

        Vector3 smoothedposition = Vector3.Lerp(transform.position, desiredposition, smoothspeed);

        transform.position = smoothedposition;

        transform.LookAt(target);

    }




}
