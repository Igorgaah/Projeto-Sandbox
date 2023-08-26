using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachineController : MonoBehaviour
{
    private StateBase currentState;

    private void Start()
    {
        // Defina o estado inicial (Idle)
        currentState = new IdleState();
        currentState.EnterState();
    }

    private void Update()
    {
        // Atualize o estado atual
        currentState.UpdateState();

        // Exemplo de mudança de estado (apenas para fins de demonstração)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ChangeState(new MoveState());
        }
    }

    private void ChangeState(StateBase newState)
    {
        // Saia do estado atual
        currentState = newState;
        currentState.EnterState();
    }
}
