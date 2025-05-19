using UnityEngine;

public class CameraFocus : MonoBehaviour
{
    public Transform target; // Assign the object to focus on in the Inspector
    public Vector3 offset = new Vector3(0, 5, -10); // Camera offset from the target
    public float smoothSpeed = 0.125f; // Smoothing factor

    void LateUpdate()
    {
        if (target == null) return;

        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        transform.LookAt(target);
    }
}