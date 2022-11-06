using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise08 : MonoBehaviour
{
    public string month = "january"; //String that store a name of a month
    
    // Start is called before the first frame update
    void Start()
    {
        //Display the days of the desired month
        //Month with 31 days
        if ((month == "january") || (month == "march") || (month == "may") || (month == "july") || (month == "august") || (month == "october") || (month == "december"))
        {
            Debug.Log($"The month {month} has 31 days");
        }
        else {
            //Month with 30 days
            if ((month == "april") || (month == "june") || (month == "september") || (month == "november")) {
                Debug.Log($"The month {month} has 30 days");
            }
            else
            {
                //Month with 28 days
                if (month == "february") {
                    Debug.Log($"The month {month} has 28 days");
                }
            }
        }
    }

}
