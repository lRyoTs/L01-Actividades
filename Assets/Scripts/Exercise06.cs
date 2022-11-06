using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise06 : MonoBehaviour
{
    public int day = 1; //Store the day (1-7 only)
    
    // Start is called before the first frame update
    void Start()
    {
        //Choose if the day is from the weekend or not
        if ((day == 1) || (day == 2) || (day == 3) || (day == 4) || (day == 5)) 
        {
            Debug.Log($"Day {day} doesn't belong to the weekend");
        }
        else if ((day == 6) || (day == 7)) {
            Debug.Log($"Day {day} belongs to the weekend");
        }
    }

}
