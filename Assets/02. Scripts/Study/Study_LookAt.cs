using UnityEngine;

public class Study_LookAt : MonoBehaviour
{
    public Transform targetTf;          // 터렛이 바라볼 대상
    public Transform turretHead;

    public GameObject bulletPrefab;     // 총알 프리팹
    public Transform firePos;

    public float timer;
    public float cooldownTime;

    void Start()
    {
        targetTf = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // 물체를 바라보는 기능
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
