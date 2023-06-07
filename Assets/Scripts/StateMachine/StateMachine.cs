using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    public IState CurrentState { get; set; }
    private StateMachine _sm;

    private void Awake()
    {
        _sm = GetComponent<StateMachine>();
        _sm.Initialize(new StateMainMenu());
    }

    public void Initialize(IState startState)
    {
        CurrentState = startState;
        CurrentState.Enter();
    }

    public void ChangeState(IState newState)
    {
        CurrentState.Exit();
        CurrentState = newState;
        CurrentState.Enter();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            _sm.ChangeState(new StateMainMenu());

        if (Input.GetKeyDown(KeyCode.Alpha2))
            _sm.ChangeState(new StateGameflow());
        
        if (Input.GetKeyDown(KeyCode.Alpha3))
            _sm.ChangeState(new StateOptionsMenu());
    }
}
