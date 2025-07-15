using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SionKim : Human
{
    void Start()
    {
        myName = "김시온";
        myAge = 23;
        Debug.Log(myName);
        Eat();
    }
}
