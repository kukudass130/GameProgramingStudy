using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon
{
    // public string name;
    // public int damage;
    // public Weapon()
    // {
    //     name = "Unknown";
    //     damage = 10;
    // }
    // public Weapon(string name, int damage)
    // {
    //     this.name = name;
    //     this.damage = damage;
    // }
    public string Name{get; set;}
    public virtual void Attack(){
        Debug.Log("Weapon Attacks");
    }
}
