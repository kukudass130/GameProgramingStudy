using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class FirstScript : MonoBehaviour
{
    void Start()
    {
        IMovable mover = new Cat();
        mover.Move();
        Cat cat = new Cat();
        cat.Eat();

        mover= new Dog();
        mover.Move();
        Dog dog = new Dog();
        dog.Eat();

    }
       void Update()
    {
        
    }
}
