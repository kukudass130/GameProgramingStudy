using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : Enemy
{
    public override void Die(){
        Debug.Log("좀비가 죽었습니다.");
        Debug.Log("좀비에게 안식을 되찾아주었습니다.");
    }
}
