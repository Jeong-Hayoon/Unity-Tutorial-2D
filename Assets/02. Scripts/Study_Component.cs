using UnityEngine;

public class Study_Component : MonoBehaviour
{
    // ����Ƽ���� ������ ���ڿ� ����
    // public string m_changeName;

    private GameObject obj;

    public Transform objTf;

    public Mesh msh;
    public Material mat;

    void Start()
    {
        // �ش� �̸��� ������Ʈ�� ã�Ƽ� �Ҵ�
        // obj = GameObject.Find("Main Camera");

        // ť�� ������Ʈ�� �̸��� �ٲٴ� ���
        //obj.name = m_changeName;

        // ������Ʈ ����
        //Debug.Log($"<color=#FF0000>�̸� : {obj.name}</color>");                    // ���� ������Ʈ�� �̸�
        //Debug.Log($"<color=#00FF00>�±� : {obj.tag}</color>");                     // ���� ������Ʈ�� �±�
        //Debug.Log($"<color=#0000FF>��ġ : {obj.transform.position}</color>");      // ���� ������Ʈ�� Transform ������Ʈ�� ��ġ
        //Debug.Log($"<color=#FFFF00>ȸ�� : {obj.transform.rotation}</color>");      // ���� ������Ʈ�� Transform ������Ʈ�� ȸ��    
        //Debug.Log($"<color=#FF00FF>ũ�� : {obj.transform.lossyScale}</color>");    // ���� ������Ʈ�� Transform ������Ʈ�� ũ��

        //// MeshFilter ������Ʈ�� �����ؼ� mesh�� Log �޼����� ����ϴ� ���
        //Debug.Log($"Mesh ������ :{obj.GetComponent<MeshFilter>().mesh} ");

        //// MeshRenderer ������Ʈ�� �����ؼ� material�� Log �޼����� ����ϴ� ���
        //Debug.Log($"Material ������ : {obj.GetComponent<MeshRenderer>().material}");

        // ������Ʈ ��Ȱ��ȭ
        //obj.GetComponent<MeshRenderer>().enabled = false;

        // �±׸� ���� ������Ʈ �˻�
        //obj = GameObject.FindGameObjectWithTag("Player");
        //objTf = GameObject.FindGameObjectWithTag("Player").transform;

        // ������Ʈ ��Ȱ��ȭ
        //objTf.gameObject.SetActive(false);

        // obj = new GameObject();
        // obj.name = "Cube";

        CreateCube();

    }

    public void CreateCube()
    {
        // �̸��� �־ �� ���� ������Ʈ ����(�����)
        obj = new GameObject("Cube");

        obj.AddComponent<MeshFilter>();
        obj.GetComponent<MeshFilter>().mesh = msh;

        obj.AddComponent<MeshRenderer>();
        obj.GetComponent<MeshRenderer>().material = mat;

        obj.AddComponent<BoxCollider>();
    }
}
