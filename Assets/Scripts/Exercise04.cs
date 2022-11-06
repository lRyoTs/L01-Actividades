using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise04 : MonoBehaviour
{
    public int currentYear = 2022;
    public int birthYear = 2000;

    // Start is called before the first frame update
    void Start()
    {
        int age; //Store user current age
        age = currentYear - birthYear; //Operation to get the age
        //Display
        Debug.Log($"If we are in the year {currentYear} and you were born in {birthYear}, you are {age} years old");
    }

}
