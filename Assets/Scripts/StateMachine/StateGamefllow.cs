using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateGameflow : IState
{
    public void Enter() => Debug.Log("Gameflow Entered");
    public void Exit() => Debug.Log("Gameflow Exited");
}