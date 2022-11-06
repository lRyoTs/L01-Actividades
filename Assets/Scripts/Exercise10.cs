using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise10 : MonoBehaviour
{
    public int number = 2; 

    // Start is called before the first frame update
    void Start()
    {
        string message = ""; //Stores the message to display
        //Get multiplication table of the selected number
        for(int i = 1; i <= 10; i++)
        {
            message += $"{number} x {i} = {number * i}\n";
        }
        //Display multiplication table message
        Debug.Log(message);
    }
}
