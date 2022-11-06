using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise09 : MonoBehaviour
{
    public int numCandy = 20; //Stores the amount of candy available
    public int people = 12; //Stores the number of person to give candies
    
    // Start is called before the first frame update
    void Start()
    {
        int numCandyShared; //Store the amount of candy shared to each person
        numCandyShared = numCandy / people;
        
        int leftover; //Store the leftover that aren't shared to people
        leftover = numCandy % people;

        //Display
        Debug.Log($"With {numCandy} candies. We can share {numCandyShared} candies for {people} people with {leftover} leftovers");
    }

}
