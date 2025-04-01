using UnityEngine;

public class Wheel : MonoBehaviour
{
    public new WheelCollider collider;
    public Transform motobloc;

    private void LateUpdate()
    {
        collider.GetWorldPose(out Vector3 pos, out Quaternion rot);
        transform.position = pos;
        transform.rotation = rot;
    }
}
