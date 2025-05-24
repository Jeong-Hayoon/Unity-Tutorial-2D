using UnityEngine;

public class Study_Component : MonoBehaviour
{
    // 유니티에서 설정할 문자열 변수
    // public string m_changeName;

    private GameObject obj;

    public Transform objTf;

    public Mesh msh;
    public Material mat;

    void Start()
    {
        // 해당 이름의 오브젝트를 찾아서 할당
        // obj = GameObject.Find("Main Camera");

        // 큐브 오브젝트의 이름을 바꾸는 기능
        //obj.name = m_changeName;

        // 컴포넌트 접근
        //Debug.Log($"<color=#FF0000>이름 : {obj.name}</color>");                    // 게임 오브젝트의 이름
        //Debug.Log($"<color=#00FF00>태그 : {obj.tag}</color>");                     // 게임 오브젝트의 태그
        //Debug.Log($"<color=#0000FF>위치 : {obj.transform.position}</color>");      // 게임 오브젝트의 Transform 컴포넌트의 위치
        //Debug.Log($"<color=#FFFF00>회전 : {obj.transform.rotation}</color>");      // 게임 오브젝트의 Transform 컴포넌트의 회전    
        //Debug.Log($"<color=#FF00FF>크기 : {obj.transform.lossyScale}</color>");    // 게임 오브젝트의 Transform 컴포넌트의 크기

        //// MeshFilter 컴포넌트에 접근해서 mesh를 Log 메세지로 출력하는 기능
        //Debug.Log($"Mesh 데이터 :{obj.GetComponent<MeshFilter>().mesh} ");

        //// MeshRenderer 컴포넌트에 접근해서 material을 Log 메세지로 출력하는 기능
        //Debug.Log($"Material 데이터 : {obj.GetComponent<MeshRenderer>().material}");

        // 컴포넌트 비활성화
        //obj.GetComponent<MeshRenderer>().enabled = false;

        // 태그를 통한 컴포넌트 검색
        //obj = GameObject.FindGameObjectWithTag("Player");
        //objTf = GameObject.FindGameObjectWithTag("Player").transform;

        // 오브젝트 비활성화
        //objTf.gameObject.SetActive(false);

        // obj = new GameObject();
        // obj.name = "Cube";

        CreateCube();

    }

    public void CreateCube()
    {
        // 이름을 넣어서 빈 게임 오브젝트 생성(축약형)
        obj = new GameObject("Cube");

        obj.AddComponent<MeshFilter>();
        obj.GetComponent<MeshFilter>().mesh = msh;

        obj.AddComponent<MeshRenderer>();
        obj.GetComponent<MeshRenderer>().material = mat;

        obj.AddComponent<BoxCollider>();
    }
}
