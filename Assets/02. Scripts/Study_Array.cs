using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class Study_Array : MonoBehaviour
{
    // Array
    public int[] arrayNumber = new int[5] { 1, 2, 3, 4, 5 };

    // List
    public List<int> listNumber = new List<int>();

    [SerializeField] int number1 = 4;

    [SerializeField]
    int number2 = 3;

    void Start()
    {
        //// Array
        //Debug.Log($"Array 의 첫 번째 값 : {arrayNumber[0]}");
        //Debug.Log($"Array 의 두 번째 값 : {arrayNumber[1]}");
        //Debug.Log($"Array 의 세 번째 값 : {arrayNumber[2]}");

        //Debug.Log($"현재 Array 의 길이 : {arrayNumber.Length}");

        //// List
        //listNumber.Add(10);
        //listNumber.Add(20);
        //listNumber.Add(30);

        //Debug.Log($"현재 List 에 있는 데이터 수 : {listNumber.Count}");
        //Debug.Log($"현재 List 의 마지막 데이터 : {listNumber[listNumber.Count - 1]}");
    }
}
