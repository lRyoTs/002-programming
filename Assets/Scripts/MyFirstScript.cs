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
    public string message = "Hello World!\n";
    public int point = 256;

    private void Start()
    {
        Debug.Log(message);
        //Debug.Log("Your score: " + point +" points\n"); //Another way to concatane string and variables
        //Debug.Log($"Your actual score: {point} points\n"); //Way to concatane string and other variable
        Debug.Log(string.Format("Hello {0}, your score is {1}\n", playerUser, point)); //way to concatane string and variable using string.Format
    }
}
