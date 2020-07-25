using UnityEngine;

public class FollowPlayer : MonoBehaviour{
    public Transform playerTransform;
    public Vector3 offset;
    public float smoothSpeed = 0.125f;


    void FixedUpdate(){
        Vector3 desiredPosition = playerTransform.position + offset;
        Vector3 smoothPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothPosition;
    }
}
