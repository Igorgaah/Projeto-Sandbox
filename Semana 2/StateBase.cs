using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class StateBase
{
    public abstract void EnterState();
    public abstract void UpdateState();
}

public class IdleState : StateBase
{
    public override void EnterState()
    {
        Debug.Log("Entering Idle State");
    }

    public override void UpdateState()
    {
        Debug.Log("Idle State Update");
    }
}

public class MoveState : StateBase
{
    public override void EnterState()
    {
        Debug.Log("Entering Move State");
    }

    public override void UpdateState()
    {
        Debug.Log("Move State Update");
    }
}


