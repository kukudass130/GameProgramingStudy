using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : MonoBehaviour
{
    public string myName;
    public int myAge;
    private float myHeight;
    private bool isSolo;
    
    public void Eat(){
        print("냠냠 먹는중");
    }
    public void Sleep(){
        print("쿨쿨 잠자는중");
    }
    public void PowerPush(){
        print("힘껏 장 내 물질을 밀어낸다.");
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
