using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Diving : BaseState
{
    private MovementSM _sm;

    public Diving(MovementSM stateMachine) : base("Diving", stateMachine)
    {
        _sm = stateMachine;
    }

    public override void Enter()
    {
        base.Enter();
    }

    public override void UpdateLogic()
    {
        base.UpdateLogic();
    }
}
