using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operation : MonoBehaviour
{

    public int a = 20;
    public int b = 6;
    // Start is called before the first frame update
    void Start()
    {
        Calculator((float)a, (float)b);

    }

    private void Calculator(float num1, float num2) {
        float result; //Stores de value of the operations
        //SUM
        result = num1 + num2;
        Debug.Log($"Sum: {num1}+{num2} = {result}");
        //SUBTRACT
        result = num1 - num2;
        Debug.Log($"Subtraction: {num1} - {num2} = {result}");
        //PRODUCT
        result = num1 * num2;
        Debug.Log($"Product: {num1}*{num2} = {result}");
        //DIVISION
        result = (float)num1 / num2;
        Debug.Log($"Division: {num1}/{num2} = {result}");
        //MODULE
        result = num1 % num2;
        Debug.Log($"Module: {num1}%{num2} = {result}");
    }
}
