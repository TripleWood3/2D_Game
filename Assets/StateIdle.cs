using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateIdle : IState
{
    private Moveable _moveable;
    public StateIdle(Moveable moveable)
    {
        _moveable = moveable;
    }
    public void OnEnter()
    {
        _moveable.enabled = false;
    }

    public void OnExit()
    {
        
    }

    public void Tick()
    {
        
    }
}
