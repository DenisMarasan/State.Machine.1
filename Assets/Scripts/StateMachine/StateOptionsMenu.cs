using UnityEngine;

public class StateOptionsMenu : IState
{
    public void Enter() => Debug.Log("Options Menu Entered");
    public void Exit() => Debug.Log("Options Menu Exited");
}