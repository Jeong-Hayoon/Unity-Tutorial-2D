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
        //Debug.Log($"Array �� ù ��° �� : {arrayNumber[0]}");
        //Debug.Log($"Array �� �� ��° �� : {arrayNumber[1]}");
        //Debug.Log($"Array �� �� ��° �� : {arrayNumber[2]}");

        //Debug.Log($"���� Array �� ���� : {arrayNumber.Length}");

        //// List
        //listNumber.Add(10);
        //listNumber.Add(20);
        //listNumber.Add(30);

        //Debug.Log($"���� List �� �ִ� ������ �� : {listNumber.Count}");
        //Debug.Log($"���� List �� ������ ������ : {listNumber[listNumber.Count - 1]}");
    }
}
