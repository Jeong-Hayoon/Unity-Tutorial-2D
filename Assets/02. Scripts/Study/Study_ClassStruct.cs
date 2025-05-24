using UnityEngine;

public class Study_Class
{
    public int number;

    // 생성자
    public Study_Class(int _number)
    {
        number = _number;
    }
}

public struct Study_Struct
{
    public int number;

    // 생성자
    public Study_Struct(int _number)
    {
        number = _number;
    }

}

public class Study_ClassStruct : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("--- 클래스 ---");
        Study_Class class1 = new Study_Class(10);
        Study_Class class2 = class1;
        Debug.Log($"class1 : {class1.number} / class2 : {class2.number}");
        
        class1.number = 100;
        Debug.Log($"class1 : {class1.number} / class2 : {class2.number}");

        Debug.Log("--- 구조체 ---");
        Study_Struct struct1 = new Study_Struct(10);
        Study_Struct struct2 = struct1;
        Debug.Log($"struct1 : {struct1.number} / struct2 : {struct2.number}");

        struct1.number = 100;
        Debug.Log($"struct1 : {struct1.number} / struct2 : {struct2.number}");

    }
}
