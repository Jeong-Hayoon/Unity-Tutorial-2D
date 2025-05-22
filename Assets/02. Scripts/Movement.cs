using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //// 앞으로 가는 기능
        //if (Input.GetKey(KeyCode.W))
        //{
        //    transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
        //}

        //// 뒤로 가는 기능
        //if (Input.GetKey(KeyCode.S))
        //{
        //    transform.position += Vector3.back * moveSpeed * Time.deltaTime;
        //}

        //// 왼쪽으로 가는 기능
        //if (Input.GetKey(KeyCode.A))
        //{
        //    transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        //}

        //// 오른쪽으로 가는 기능
        //if (Input.GetKey(KeyCode.D))
        //{
        //    transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        //}

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(h, 0, v);
        Debug.Log($"현재 입력 : {dir}");

        transform.position += dir * moveSpeed * Time.deltaTime;
    }
}
