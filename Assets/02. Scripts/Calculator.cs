using UnityEngine;

public class Calculator : MonoBehaviour
{
    // 멤버 변수(필드)
    public int number1 = 0;
    public int number2 = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int addResult = Add();
        int minusResult = Minus();

        Debug.Log($"더한 값 : {addResult} / 뺀 값 : {minusResult}");
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
