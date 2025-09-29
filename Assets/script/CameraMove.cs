using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class CameraMove : MonoBehaviour
{
    public Transform target; // �÷��̾��� Transform
    public float smoothTime = 0.3f; // ī�޶� ���󰡴� �� �ɸ��� �ð� (���� �������� ����)
    public Vector3 offset = new Vector3(0, 0, -10);

    private Vector3 velocity = Vector3.zero;

    void LateUpdate()
    {
        if (target == null) return;

        Vector3 targetPosition = target.position + offset;

        // ���� ��ġ���� ��ǥ ��ġ���� �ε巴�� �̵�
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
}
