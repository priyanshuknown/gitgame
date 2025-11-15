using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public Transform vehicle;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;
    
    void LateUpdate()
    {
        Transform target = player; // Default to player
        // Switch to vehicle if it's active and not null
        if (vehicle != null && vehicle.gameObject.activeSelf)
        {
            target = vehicle;
        }
        
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
        
        transform.LookAt(target);
    }
}