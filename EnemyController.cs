using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 3f; // Velocidade de movimento do inimigo

    private Transform player; // Referência ao jogador

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        MoveEnemy();
    }

    private void MoveEnemy()
    {
        // Calcula a direção do inimigo em relação ao jogador
        Vector3 direction = player.position - transform.position;

        // Normaliza o vetor de direção para manter a velocidade constante
        direction = direction.normalized;

        // Move o inimigo em direção ao jogador
        transform.Translate(direction * speed * Time.deltaTime);
    }
}