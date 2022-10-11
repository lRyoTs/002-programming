using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    //VARIABLES
    [SerializeField] private int wheels = 4; //Saves the number of wheels of the vehicle
    [SerializeField] private string name;

    private void Start()
    {
        Debug.Log($"The {name} has {wheels} wheels");
    }
   
}
