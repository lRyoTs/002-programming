using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    /*
     * 4 variable with player information
     */
    //User Age
    public int playerAge = 23;
    //Player actual speed
    private float playerSpeed = 3.123f;
    public string playerUser = "ElHeeHee"; //player's nickname
    [SerializeField] private bool isGameOver = false; //Has the player lost?
}
