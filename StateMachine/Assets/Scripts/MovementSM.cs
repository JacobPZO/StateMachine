using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementSM : StateMachine
{
    [HideInInspector]
    public Standing standingState;
    [HideInInspector]
    public Moving movingState;
    [HideInInspector]
    public Jumping jumpingState;
    [HideInInspector]
    public Airdash airdashState;
    [HideInInspector]
    public Diving divingState;
    [HideInInspector]
    public Sprinting sprintingState;

    private void Awake()
    {
        standingState = new Standing(this);
        movingState = new Moving(this);
        jumpingState = new Jumping(this);
        airdashState = new Airdash(this);
        divingState = new Diving(this);
        sprintingState = new Sprinting(this);
    }

    protected override BaseState GetInitialState()
    {
        return standingState;
    }
}
