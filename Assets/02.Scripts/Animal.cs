using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMovable
{
    void Move();
}
public class Animal
{
    public virtual void Eat(){
        Debug.Log("동물이 밥을 먹습니다.");
    }
}
