using UnityEngine;

public class PlanetRotation : MonoBehaviour
{
    public Transform targetPlanet;          // ������ ���� �Ǵ� �༺
    public bool isRevolution = false;

    public float rotSpeed = 30f;            // ���� �ӵ�
    public float revolutionSpeed = 100f;    // ���� �ӵ�

    void Update()
    {
        // �ڱ� �ڽ��� ȸ���ϴ� ���
        transform.Rotate(Vector3.up * rotSpeed * Time.deltaTime);

        // ������ �Ѵٸ�
        if (isRevolution == true)
        {
            // �����ϴ� ���
            transform.RotateAround(targetPlanet.position, Vector3.up, revolutionSpeed * Time.deltaTime);

        }
    }
}
