using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise02 : MonoBehaviour
{
    //Initiate string values
    public new string name = "Tom";
    public string city = "Manila";
    // Start is called before the first frame update
    void Start()
    {
        //Display message
        Debug.Log($"Hello, {name} ! Welcome to {city}");
    }

}
