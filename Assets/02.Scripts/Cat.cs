using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Animal, IMovable
{
    public void Move(){
        Debug.Log("고양이가 움직입니다.");
    }
    public override void Eat(){
        Debug.Log("집사야 밥내놔라");
    }
}
