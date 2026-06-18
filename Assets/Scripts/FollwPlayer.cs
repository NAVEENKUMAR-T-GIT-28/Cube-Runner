using UnityEngine;

public class FollwPlayer : MonoBehaviour
{
    public Transform PlayerTransform;
    public float OffSet;
    void Start()
    {
        OffSet = -10;
    }

    void Update()
    {
        Vector3 CameraPosition = transform.position;
        CameraPosition.z = PlayerTransform.position.z + OffSet;
        transform.position = CameraPosition;
    } 
}
