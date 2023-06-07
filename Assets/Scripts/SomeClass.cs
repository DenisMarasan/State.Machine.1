using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeClass : MonoBehaviour
{
    private StateMachine _sm;

    void Start()
    {
        _sm = new StateMachine();
        _sm.Initialize(new StateMainMenu());
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) 
        { 
            _sm.ChangeState(new StateMainMenu());
        }

        if(Input.GetKeyDown(KeyCode.Alpha2)) 
        { 
        _sm.ChangeState(new StateGameflow());
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            _sm.ChangeState(new StateOptionsMenu());
        }
    }
}
