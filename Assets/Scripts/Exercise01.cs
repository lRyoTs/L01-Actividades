using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise01 : MonoBehaviour
{
    //Initiate variables
    public float num1 = 1;
    public float num2 = 2;
    public float num3 = 3;

    void Start()
    {
        float result; //Initiate variable result to store the sum
        result = num1 + num2 + num3; //Sum of the 3 variables
        Debug.Log($"{num1} + {num2} + {num3} = {result}"); //Display result
    }

}
