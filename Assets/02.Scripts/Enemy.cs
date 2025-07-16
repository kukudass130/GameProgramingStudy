using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy
{
    public virtual void Die(){
        Debug.Log("적이 사라졌다!");
    }
}
