using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal, IMovable
{
    // public override void Speak(){
    //     Debug.Log("Dog barks");
    // }
    public void Move(){
        Debug.Log("강아지가 움직입니다.");
    }
    public override void Eat(){
        Debug.Log("밥밥밥! 촵촵");
    }
}
