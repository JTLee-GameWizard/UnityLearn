using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerInputSystemTest : MonoBehaviour
{
    private PlayerInputs PlayerInputActions;
    public Vector2 InputMovement;
    public Vector2 InputView;
    public float mouseY_ScrollAmt;
    public bool bIsSprinting;
    private void Awake()
    {
        InitInputBind();
    }
    private void Jump()
    {
        Debug.Log("I am jumping");
    }

    private void SuperJump()
    {
        Debug.Log("Super Jumping");
    }
    
    private void OnDisable()
    {
        DisableInput();
    }

    private void Update()
    {
        
    }

    private void InitInputBind()
    {
        PlayerInputActions = new PlayerInputs();
        PlayerInputActions.Enable();
        //Jump    
        PlayerInputActions.Actions.Jump.performed += x => Jump();
        PlayerInputActions.Actions.SuperJump.performed += x => SuperJump();
       
        //movement
        PlayerInputActions.Movement.Movement.performed += context => InputMovement = context.ReadValue<Vector2>();
        PlayerInputActions.Movement.View.performed += context => InputView = context.ReadValue<Vector2>();
        
        //sprint
        PlayerInputActions.Movement.SprintStart.performed += c => SprintPressed();
        PlayerInputActions.Movement.SprintFinish.performed += c => SprintingReleased();

        //mouse scroll
        PlayerInputActions.MouseScroll.Scroll.performed += context => mouseY_ScrollAmt = context.ReadValue<float>();
    }

    private void SprintPressed()
    {
        bIsSprinting = true;
    }

    private void SprintingReleased()
    {
        bIsSprinting = false;
    }
    private void DisableInput()
    {
        if (PlayerInputActions != null)
        {
            PlayerInputActions.Disable();
        }
    }
}
