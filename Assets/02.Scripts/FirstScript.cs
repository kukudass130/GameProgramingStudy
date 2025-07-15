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
    // 
    // int[] myArray = new int[3];
    // int[] myArray2 = {3,6,9};

    public List<int> myList = new List<int>();
    public List<int> myList2 = new List<int> {4, 6, 9};

    public int[] myArray = {1,2};
    public int[] myArray2;

    int count = 0;
    int[] myArray3 = {0,3,6,9,12,15,18,21,24,27};
    List<string> names = new List<string> {"페이커", "페이커2", "페이커3"};

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
        // EnemyAttack();
        // EnemyAttack();
        // EnemyAttack();
        // Debug.Log(nextYear(2025));
        // Debug.Log(Plus(3,97));
        // Debug.Log(Minus(97,3));
        // Debug.Log(Multiply(3,97));
        // Debug.Log(Divide(97,3));
        // myList.Add(3);
        // myList.Add(8);
        // myList.Add(15);
        // myList.Insert(1, 7);
        // myList.Insert(2, 14);
        // myList.RemoveAt(1);
        // myList.Add(22);
        // myList.Remove(4);
        // myList.Remove(8);
        // myList.RemoveAt(3);
        // myList.Add(30);
        // myList.Add(45);
        // myList.Insert(4,12);
        // myList.RemoveAt(5);
        // myList.Remove(7);
        // myList.Add(27);

        // int a = 5;
        // int b = a;

        // b = 10;
        // Debug.Log(a);
        // Debug.Log(b);

        // myArray2 = myArray;
        // myArray2[1] = 7;
        // Debug.Log(myArray2[1]);
        // Debug.Log(myArray[1]);
        // while(count <10){
        //     Debug.Log("미니언 소환");
        //     count++;
        // }
        // for(int i = 0; i<myArray3.Length; i++){
        //     Debug.Log(myArray3[i]);
        // }
        foreach(string name in names){
            Debug.Log(name);
        }
    }
    void EnemyAttack()
    {
            Debug.Log("Enemy Attack");
            Debug.Log("Enemy Damage");
            Debug.Log("Enemy HP UI Update");
    }
    int nextYear(int thisYear){
        int nextYear=thisYear+1;
        return nextYear;
    }
    int Plus(int a, int b){
        int sum = a+b;
        return sum;
    }
    int Minus(int a, int b){
        int sum = a-b;
        return sum;
    }
    int Multiply(int a, int b){
        int sum = a*b;
        return sum;
    }
    float Divide(int a, int b){
        float sum = (float)a/(float)b;
        return sum;
    }
    int Divide(int a, int b, int c){
        int sum = a/b*c;
        return sum;
    }
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
        // if(Input.GetKeyDown(KeyCode.Space)){
        //     hp = hp - 20;
        //     switch(hp){
        //         case DEAD_HP:
        //             Debug.Log("Game Over");
        //             break;
        //         case DANGER_HP:
        //             Debug.Log("체력이 40% 이하입니다.");
        //             Debug.Log("비상!!!");
        //             break;
        //         case WARNING_HP:
        //             Debug.Log("체력이 60% 이하입니다. 조심하세요!");
        //             break;
        //         default:
        //             Debug.Log("기본 메세지입니다.");
        //             Debug.Log("hp is " + hp);
        //             break;
        //     }
        // }
        // if(Input.GetKeyDown(KeyCode.A)){
        //     switch(myFruit){
        //         case Fruit.APPLE:
        //             Debug.Log("사과는 맛있어!");
        //             break;
        //         case Fruit.BANANA:
        //             Debug.Log("바나나는 맛있어!");
        //             break;
        //         case Fruit.PEACH:
        //             Debug.Log("복숭아는 맛있엄");
        //             break;
        //         case Fruit.ORANGE:
        //             Debug.Log("오렌지는 맛있어!");
        //             break;
        //         default:
        //             Debug.Log("에러입니다.");
        //             break;
        //     }
        // }
    }
}
