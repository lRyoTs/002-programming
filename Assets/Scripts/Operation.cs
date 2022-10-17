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
        //SUM
        float result = a+b;
        Debug.Log($"Sum: {a}+{b} = {result}");
        //SUBTRACT
        result = a-b;
        Debug.Log($"Subtraction: {a} - {b} = {result}");
        //PRODUCT
        result = a* b;
        Debug.Log($"Product: {a}*{b} = {result}");
        //DIVISION
        result = (float)a/ b;
        Debug.Log($"Division: {a}/{b} = {result}");
        //MODULE
        result = a%b;
        Debug.Log($"Module: {a}%{b} = {result}");

    }

}
