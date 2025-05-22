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

        // 매개 변수로 들어간 게임 오브젝트를 파괴하는 기능
        // Destroy(destroyObj);

        // 3 초 뒤에 파괴
        //Destroy(destroyObj, 3f);
    }

    /// 어몽어스 캐릭터를 생성하고 이름을 변경하는 기능
    public void CreateAmongus()
    {
        // GameObject 생성
        GameObject obj = Instantiate(prefab);
        obj.name = "어몽어스 캐릭터";

        Transform objTf = obj.transform;
        int count = objTf.childCount;

        Debug.Log($"캐릭터의 자식 오브젝트의 수 : {count}");

        Debug.Log($"캐릭터의 첫번째 자식 오브젝트의 이름 : {objTf.GetChild(0).name}");

        Debug.Log($"캐릭터의 마지막 자식 오브젝트의 이름 : {objTf.GetChild(count - 1).name}");
    }

}
