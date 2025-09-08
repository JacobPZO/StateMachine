using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Moving : BaseState
{
    private MovementSM _sm;
    private float _horizontalInput;

    public Moving(MovementSM stateMachine) : base("Moving", stateMachine)
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
            stateMachine.ChangeState(_sm.standingState);
        } 
        
        if (Input.GetKeyDown(KeyCode.UpArrow)) 
        {
            stateMachine.ChangeState(_sm.jumpingState);
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            stateMachine.ChangeState(_sm.sprintingState);
        }
    }
}
