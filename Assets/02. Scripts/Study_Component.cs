using UnityEngine;

public class Study_Component : MonoBehaviour
{
    private GameObject obj;

    // ����Ƽ���� ������ ���ڿ� ����
    public string m_changeName;
    void Start()
    {
        // �ش� �̸��� ������Ʈ�� ã�Ƽ� �Ҵ�
        obj = GameObject.Find("Main Camera");

        // ť�� ������Ʈ�� �̸��� �ٲٴ� ���
        obj.name = m_changeName;
    }
}
