using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public delegate void GameOverEvent();
    public static event GameOverEvent OnGameOver;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("PlayerController: 'G'버튼을 누르면 게임오버입니다.");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.G))
        {
            TriggerGameOver();
        }
    }
    void TriggerGameOver()
    {
        Debug.Log("PlayerController: 게임오버!!");
        if(OnGameOver != null)
        {
            OnGameOver(); //이벤트 호출
        }
    }
}
