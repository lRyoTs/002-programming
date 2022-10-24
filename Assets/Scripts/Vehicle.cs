using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    //VARIABLES
    [SerializeField] private int wheels = 4; //Saves the number of wheels of the vehicle
    [SerializeField] private string name;
    [SerializeField] private bool isOn;
    [SerializeField] public string sound;

    private void Start()
    {

        //Debug.Log($"The {name} has {wheels} wheels");
        if (!isOn)
        {
            Debug.Log($"{name} is off");
        }
        else if (sound!="")
        {
            Debug.Log($"{name} is on and does {sound}");
        }
        else {
            Debug.Log($"{name} is running");
        }

    }
   
}
