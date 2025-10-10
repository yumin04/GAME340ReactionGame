using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Game : MonoBehaviour
{
    private Action whenSpaceClicked;
    private Action whenRClicked;

    void Awake()
    {
        whenSpaceClicked = GameMediator.GetInstance().GetWhenSpacePressed();
        whenRClicked = GameMediator.GetInstance().GetWhenRPressed();
    }
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            GameMediator.GetInstance().Notify(whenSpaceClicked);
        }
        if (Keyboard.current.rKey.wasPressedThisFrame)
        {
            GameMediator.GetInstance().Notify(whenRClicked);
        }
    }
}
