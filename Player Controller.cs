using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f; // Velocidade de movimento do jogador

    private Rigidbody2D rigidBody;

    private void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Captura o input horizontal (eixo X)
        float moveHorizontal = Input.GetAxis("Horizontal");

        // Calcula o vetor de movimento
        Vector2 movement = new Vector2(moveHorizontal, 0f);

        // Aplica a velocidade ao Rigidbody
        rigidBody.velocity = movement * speed;
    }
}