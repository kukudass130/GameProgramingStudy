using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    // //정수타입 변수 선언
    // private int lastYear=2024;
    // public int thisYear=2025;

    // //float타입 변수 선언
    // private float pi;
    // //문자열 변수 선언
    // private string myName;
    // //bool타입 변수 선언
    // private bool isGameOver = false;
    public int hp= 100;

    void Start()
    {
        // Debug.Log("This year is " + thisYear);
        // int nextYear=thisYear+1;
        // Debug.Log("Next year is " + nextYear);
        // pi=3.14f;
        // Debug.Log("pi is " + pi);
        // myName = "페이커";
        // Debug.Log("My name is " + myName);
        // Debug.Log("현재 게임 오버 상태 : " + isGameOver);

    }

    // Update is called once per frame
    void Update()
    {
        //프레임 단위로 반복 실행
        //Debug.Log("Last year is " + lastYear);
        // if(Input.GetKeyDown(KeyCode.Space)){
        //     hp = hp - 20;
        //     if(hp<=0){
        //         Debug.Log("Game Over");
        //     }
        //     else if(hp <= 40){
        //         Debug.Log("체력이 40% 이하입니다.");
        //         Debug.Log("비상!!!");
        //     }
        //     else if(hp <= 60){
        //         Debug.Log("체력이 60% 이하입니다. 조심하세요!");
        //     }
        //     else{
        //         Debug.Log("hp is " + hp);
        //     }
        // }
        if(Input.GetKeyDown(KeyCode.Space)){
            hp = hp - 20;
            switch(hp){
                case 0:
                    Debug.Log("Game Over");
                    break;
                case 40:
                    Debug.Log("체력이 40% 이하입니다.");
                    Debug.Log("비상!!!");
                    break;
                case 60:
                    Debug.Log("체력이 60% 이하입니다. 조심하세요!");
                    break;
                default:
                    Debug.Log("기본 메세지입니다.");
                    Debug.Log("hp is " + hp);
                    break;
            }
        }
    }
}
