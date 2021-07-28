using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class PlayerCharacterWithInput : MonoBehaviour
{
    InputCompActions inputCompActions;
    // Start is called before the first frame update
    private void Awake()
    {
        inputCompActions = new InputCompActions();
        inputCompActions.Enable();
        inputCompActions.Gameplay.Jump.performed += EventJump;
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        InputActionPhase JumpPhase = inputCompActions.Gameplay.Jump.phase;
        Debug.Log("Jump Action Phase is: " + JumpPhase);
    }

    void Jump()
    {
        Debug.Log("I am jumping");
    }

    void OnJump(string Msg)
    {
        Debug.Log(Msg);
    }

    public void EventJump(InputAction.CallbackContext ctx)
    {
        Debug.Log("Performed");
        switch (ctx.phase)
        {
            case InputActionPhase.Started:
                Debug.Log("Jump Action Started");
                break;
            case InputActionPhase.Performed:
                Jump();
                break;
            case InputActionPhase.Canceled:
                Debug.Log("Jump Action Canceled");
                break;
        }
    }
}
