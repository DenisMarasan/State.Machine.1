using UnityEngine;

public class StateMainMenu : IState
{
    public void Enter() => Debug.Log("Main Menu Entered");
    public void Exit() => Debug.Log("Main Menu Exited");
}