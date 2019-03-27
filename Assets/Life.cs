using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    public class Points
    {
        public int points;

        // Constructor
        public Points()
        {
            points = 5;
        }
    }


    // Creating an Instance (an Object) of the Stuff class
    public Points myPoint = new Points();

    void Start()
    {
        Debug.Log(myPoint.points);
    }
}