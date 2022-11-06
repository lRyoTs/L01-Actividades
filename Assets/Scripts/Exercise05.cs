using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise05 : MonoBehaviour
{
    public int num1 = 1;
    public int num2 = 2;

    // Start is called before the first frame update
    void Start()
    {
        //Choose which number is greater to display
        if (num1 > num2)
        {
            Debug.Log($"{num1} is greater than {num2}");
        }
        else if (num2 > num1)
        {
            Debug.Log($"{num2} is greater than {num1}");
        }
        else {
            Debug.Log($"{num1} and {num2} are the same");
        }
    }
}
