using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    protected string name;
    protected int health;

    public Character(string name, int health)
    {
        this.name = name;
        this.health = health;
    }

    public virtual void Attack()
    {
        Debug.Log(name + " is attacking!");
    }
}