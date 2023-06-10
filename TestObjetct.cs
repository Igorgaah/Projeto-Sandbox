using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestObject : MonoBehaviour
{
    private void Start()
    {
        // Criando um objeto Player
        Player player = new Player("Player 1", 100, 10, 5);
        player.Attack();
        player.SpecialAttack();
        player.TakeDamage(20);
    }
}
