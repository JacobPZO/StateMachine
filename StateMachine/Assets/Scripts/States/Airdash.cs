using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Airdash : BaseState
{
    private MovementSM _sm;
    private float _horizontalInput;

    public Airdash(MovementSM stateMachine) : base("Airdash", stateMachine)
    {
        _sm = stateMachine;
    }

    public override void Enter()
    {
        base.Enter();
        _horizontalInput = 0f;
    }

    public override void UpdateLogic()
    {
        base.UpdateLogic();
        _horizontalInput = Input.GetAxis("Horizontal");
        if (Mathf.Abs(_horizontalInput) < Mathf.Epsilon)
        {
            stateMachine.ChangeState(_sm.jumpingState);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            stateMachine.ChangeState(_sm.divingState);
        }
    }
}
