using UnityEngine;

public class Study_Component : MonoBehaviour
{
    private GameObject obj;

    // 유니티에서 설정할 문자열 변수
    public string m_changeName;
    void Start()
    {
        // 해당 이름의 오브젝트를 찾아서 할당
        obj = GameObject.Find("Main Camera");

        // 큐브 오브젝트의 이름을 바꾸는 기능
        obj.name = m_changeName;
    }
}
