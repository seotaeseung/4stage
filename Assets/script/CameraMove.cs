using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class CameraMove : MonoBehaviour
{
    public Transform target; // 플레이어의 Transform
    public float smoothTime = 0.3f; // 카메라가 따라가는 데 걸리는 시간 (값이 작을수록 빠름)
    public Vector3 offset = new Vector3(0, 0, -10);

    private Vector3 velocity = Vector3.zero;

    void LateUpdate()
    {
        if (target == null) return;

        Vector3 targetPosition = target.position + offset;

        // 현재 위치에서 목표 위치까지 부드럽게 이동
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
}
