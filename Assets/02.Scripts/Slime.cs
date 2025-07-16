using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : Enemy
{
    public override void Die(){
        Debug.Log("슬라임이 죽었습니다.");
        Debug.Log("투명한 액체가 땅으로 스며듭니다.");
    }
}
