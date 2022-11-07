using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    //VARIABLES
    [SerializeField] private int wheels = 4; //Saves the number of wheels of the vehicle
    [SerializeField] private string name;
    [SerializeField] private bool isOn;
    public string sound; //Vehicle sound
    [SerializeField] private float gasoline; //Stores the current value of gasoline
    [SerializeField] private float lowGas; //Indicates if the gasoline lower than this value
    public bool canGetBigger = true;

    private void Start()
    {
        //Debug.Log($"The {name} has {wheels} wheels");
        if (!isOn)
        {
            Debug.Log($"{name} is off");
        }
        else {
            if (sound != "")
            {
                Debug.Log($"{name} is on and does {sound}");
            }
            else {
                Debug.Log($"{name} is running");
            }

            if (gasoline < lowGas)
            {
                Debug.Log($"{name} is running low of gasoline");
            }
            else if (gasoline == 0)
            {
                Debug.Log($"The {name} doesn't have gasoline");
            }
            else { 
                Debug.Log($"The {name} has {gasoline} L of gasoline");
            }
        }
    }

    //Updates every frame
    private void Update()
    {
        if (canGetBigger) {
            if (Input.GetMouseButtonDown(0))
            {
                transform.localScale += Vector3.one;
            }
            else if (Input.GetMouseButtonDown(1)) {
                transform.localScale -= Vector3.one;
            }
        }
    }
}
