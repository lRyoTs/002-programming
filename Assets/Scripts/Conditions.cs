using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditions : MonoBehaviour
{
    public string a = "10";
    public string b = "4";
    public int number = 0;
    public string opcion;
    // Start is called before the first frame update
    void Start() {
        //Debug.Log(AreaEqual(a, b));
        for (int i = 0; i <= 10; i++) {
            Debug.Log(Comparing(opcion,number, i));
        }
    }

    private string AreaEqual(string a, string b) {
        return $"{a} and {b} are equal? {a==b}";
    }

    private string Comparing(string opcion,int a, int b) {
        switch (opcion) {
            case ">":
                if (a > b)
                {
                    return $"{a} is greater than {b}";
                }
                else { 
                    return $"{a} isn't greater than {b}";
                }
            case "<":
                if (a < b)
                {
                    return $"{a} is lower than {b}";
                }
                else
                {
                    return $"{a} isn't lower than {b}";
                }
            case ">=":
                if (a >= b)
                {
                    return $"{a} is greater than or equal to {b}";
                }
                else
                {
                    return $"{a} isn't greater than or equal to {b}";
                }
            case "<=":
                if (a <= b)
                {
                    return $"{a} is lower than or equal to {b}";
                }
                else
                {
                    return $"{a} isn't lower than or equal to {b}";
                }
            default:
                return $"IDK";
        }
        

    }
}
