using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f; // Velocidade de movimento do jogador

    private void Update()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Calcula a direção de movimento do jogador
        Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0f);

        // Normaliza o vetor de movimento para manter a velocidade constante em todas as direções
        movement = movement.normalized * speed * Time.deltaTime;

        // Move o jogador pela quantidade calculada
        transform.Translate(movement);
    }
}