using UnityEngine;

public class Calculator : MonoBehaviour
{
    // ��� ����(�ʵ�)
    public int number1 = 0;
    public int number2 = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int addResult = Add();
        int minusResult = Minus();

        Debug.Log($"���� �� : {addResult} / �� �� : {minusResult}");
    }

    int Add()
    {
        int result = number1 + number2;

        return result;
    }

    int Minus()
    {
        int result = number1 - number2;
        return result;
    }

}
