using UnityEngine;
using UnityEngine.InputSystem;

public class GameKeyBindHandler : MonoBehaviour
{
    private GameKeyBind _input;   // auto-generated InputAction class

    private void Awake()
    {
        _input = new GameKeyBind();
    }

    private void OnEnable()
    {
        _input.Enable();

        _input.EscKey.Newaction.performed += OnEscPressed;
        _input.CheatKey.Newaction.performed += OnCheatPressed;
    }

    private void OnDisable()
    {
        _input.EscKey.Newaction.performed -= OnEscPressed;
        _input.CheatKey.Newaction.performed -= OnCheatPressed;

        _input.Disable();
    }

    private void OnEscPressed(InputAction.CallbackContext ctx)
    {
        GameUI.GetInstance()?.OnESCKeyPressed();
    }

    private void OnCheatPressed(InputAction.CallbackContext ctx)
    {
        GameUI.GetInstance()?.OnCheatKeyPressed();
    }
}