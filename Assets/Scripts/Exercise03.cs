using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise03 : MonoBehaviour
{
    //Initiate variables
    public new string name = "Tom";
    public int age = 20;
    // Start is called before the first frame update
    void Start()
    {
        //Display message
        Debug.Log($"Hello, {name}! You are {age} years old");
    }

}
