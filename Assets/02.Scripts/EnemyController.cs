using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    void OnEnable()
    {
        //이벤트 구독
        PlayerController.OnGameOver += RespondToGameOver;
    }
    void OnDisable()
    {
        PlayerController.OnGameOver -= RespondToGameOver;
    }
    void RespondToGameOver()
    {
        Debug.Log(this.gameObject.name + " : 플레이어 죽음. 적들은 다시 흩어진다.");
    }
}
