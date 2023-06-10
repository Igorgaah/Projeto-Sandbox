using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : Character
{
    protected int damage;

    public Enemy(string name, int health, int damage) : base(name, health)
    {
        this.damage = damage;
    }

    public abstract void SpecialAttack();

    public void TakeDamage(int amount)
    {
        health -= amount;
        Debug.Log(name + " took " + amount + " damage. Remaining health: " + health);
    }
}
