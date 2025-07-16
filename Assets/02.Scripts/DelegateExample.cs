using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateExample : MonoBehaviour
{
    public delegate void MyDelegate(string message);
    //델리게이트가 참조할 메서드는 델리게이트 타입과 동일한 파라미터를 가져야 한다.
    void PrintMessage(string message)
    {
        Debug.Log("printMessage: " + message);
    }
    void LogMessage(string message)
    {
        Debug.Log("LogMessage: " + message);
    }
    // Start is called before the first frame update
    void Start()
    {
        MyDelegate myDelegate = null;
        myDelegate += PrintMessage;
        myDelegate += LogMessage;
        myDelegate += LogMessage;

        myDelegate("안녕, 델리게이트야!");
        myDelegate -= LogMessage;
        myDelegate("LogMessage를 지우고 호출했어");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
