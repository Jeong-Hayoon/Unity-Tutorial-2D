using UnityEngine;

public class Study_GameObject : MonoBehaviour
{
    public GameObject prefab;
    //public Vector3 pos;
    //public Quaternion rot;

    //public GameObject destroyObj;

    void Start()
    {
        CreateAmongus();

        // �Ű� ������ �� ���� ������Ʈ�� �ı��ϴ� ���
        // Destroy(destroyObj);

        // 3 �� �ڿ� �ı�
        //Destroy(destroyObj, 3f);
    }

    /// ���� ĳ���͸� �����ϰ� �̸��� �����ϴ� ���
    public void CreateAmongus()
    {
        // GameObject ����
        GameObject obj = Instantiate(prefab);
        obj.name = "���� ĳ����";

        Transform objTf = obj.transform;
        int count = objTf.childCount;

        Debug.Log($"ĳ������ �ڽ� ������Ʈ�� �� : {count}");

        Debug.Log($"ĳ������ ù��° �ڽ� ������Ʈ�� �̸� : {objTf.GetChild(0).name}");

        Debug.Log($"ĳ������ ������ �ڽ� ������Ʈ�� �̸� : {objTf.GetChild(count - 1).name}");
    }

}
