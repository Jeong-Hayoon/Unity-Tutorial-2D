using UnityEngine;

public class Study_LookAt : MonoBehaviour
{
    public Transform targetTf;          // �ͷ��� �ٶ� ���
    public Transform turretHead;

    public GameObject bulletPrefab;     // �Ѿ� ������
    public Transform firePos;

    public float timer;
    public float cooldownTime;

    void Start()
    {
        targetTf = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // ��ü�� �ٶ󺸴� ���
    void Update()
    {
        turretHead.LookAt(targetTf);

        timer += Time.deltaTime;
       
        if(timer >= cooldownTime)
        {
            timer = 0f;
            Instantiate(bulletPrefab, firePos.position, firePos.rotation);
        }
    }
}
